﻿using System;
using System.ComponentModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RedDocumentViewToolbarModel : ObservableObject
{
    public RedDocumentViewToolbarModel()
    {
        RefreshMenuVisibility();
        if (Locator.Current.GetService<IModifierViewStateService>() is IModifierViewStateService svc)
        {
            _modifierViewStateService = svc;
            svc.ModifierStateChanged += OnModifierChanged;
        }
    }

    private void OnModifierChanged()
    {
        IsShiftkeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;
    }

    private IModifierViewStateService? _modifierViewStateService;

    [ObservableProperty] private RedDocumentTabViewModel? _currentTab;

    public ChunkViewModel? RootChunk { get; set; }

    public string? FilePath => CurrentTab?.FilePath;
    public CR2WFile? Cr2WFile => CurrentTab?.Parent.Cr2wFile;

    [ObservableProperty] private bool _showToolbar;

    public void RefreshMenuVisibility()
    {
        ShowToolbar = CurrentTab?.GetContentType() switch
        {
            RedDocumentItemType.Mesh
                or RedDocumentItemType.App
                or RedDocumentItemType.Entity => true,
            RedDocumentItemType.Texture
                or RedDocumentItemType.MlMask
                or RedDocumentItemType.MlSetup
                or RedDocumentItemType.Sector
                or RedDocumentItemType.Other => false,
            _ => false,
        };

        if (CurrentTab is RDTDataViewModel rtdViewModel)
        {
            RootChunk = rtdViewModel.GetRootChunk();
        }
        else
        {
            RootChunk = null;
        }

        if (ShowToolbar)
        {
            RefreshMeshMenuItems();
        }
    }

    [ObservableProperty] private bool _isMesh;
    [ObservableProperty] private bool _isFileValidationMenuVisible;

    [ObservableProperty] private bool _isMaterialMenuEnabled;
    [ObservableProperty] private bool _isConvertMaterialMenuEnabled;
    [ObservableProperty] private bool _isGenerateMaterialCommandEnabled;
    [ObservableProperty] private bool _isDeleteUnusedMaterialCommandEnabled;

    [ObservableProperty] private bool _isShiftkeyDown;


    private void RefreshMeshMenuItems()
    {
        IsMesh = false;
        IsFileValidationMenuVisible = false;
        IsConvertMaterialMenuEnabled = false;
        IsMaterialMenuEnabled = false;
        IsGenerateMaterialCommandEnabled = false;
        IsDeleteUnusedMaterialCommandEnabled = false;

        if (CurrentTab is null)
        {
            return;
        }

        IsMesh = CurrentTab?.GetContentType() is RedDocumentItemType.Mesh;
        IsFileValidationMenuVisible = IsMesh || CurrentTab?.GetContentType() is RedDocumentItemType.App or RedDocumentItemType.Entity;


        if (RootChunk?.ResolvedData is not CMesh mesh)
        {
            return;
        }

        IsConvertMaterialMenuEnabled = mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0;
        IsGenerateMaterialCommandEnabled = mesh.Appearances.Count > 0;
        IsDeleteUnusedMaterialCommandEnabled = mesh.Appearances.Count > 0 || mesh.MaterialEntries.Count > 0;
    }

    public void SetCurrentTab(RedDocumentTabViewModel value)
    {
        CurrentTab = value;
        RefreshMenuVisibility();
    }
}
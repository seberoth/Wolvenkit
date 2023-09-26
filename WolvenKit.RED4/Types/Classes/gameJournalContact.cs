using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalContact : gameJournalFileEntry
	{
		[Ordinal(3)] 
		[RED("name")] 
		public LocalizationString Name
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(4)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<gameContactType> Type
		{
			get => GetPropertyValue<CEnum<gameContactType>>();
			set => SetPropertyValue<CEnum<gameContactType>>(value);
		}

		[Ordinal(6)] 
		[RED("useFlatMessageLayout")] 
		public CBool UseFlatMessageLayout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isCallableDefault")] 
		public CBool IsCallableDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalContact()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			Name = new() { Unk1 = 0, Value = "" };
			UseFlatMessageLayout = true;
			IsCallableDefault = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemSlotsFilledPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("equipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		public ItemSlotsFilledPrereqState()
		{
			EquipAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

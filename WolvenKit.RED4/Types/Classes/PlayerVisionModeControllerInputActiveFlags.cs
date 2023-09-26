using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerInputActiveFlags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CBool ButtonHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CBool ButtonToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("driverCombatButtonHold")] 
		public CBool DriverCombatButtonHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("driverCombatButtonActivate")] 
		public CBool DriverCombatButtonActivate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerVisionModeControllerInputActiveFlags()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

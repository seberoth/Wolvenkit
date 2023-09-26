using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamesmartGunUIParameters : IScriptable
	{
		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<gamesmartGunUITargetParameters> Targets
		{
			get => GetPropertyValue<CArray<gamesmartGunUITargetParameters>>();
			set => SetPropertyValue<CArray<gamesmartGunUITargetParameters>>(value);
		}

		[Ordinal(1)] 
		[RED("sight")] 
		public gamesmartGunUISightParameters Sight
		{
			get => GetPropertyValue<gamesmartGunUISightParameters>();
			set => SetPropertyValue<gamesmartGunUISightParameters>(value);
		}

		[Ordinal(2)] 
		[RED("crosshairPos")] 
		public Vector2 CrosshairPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("hasRequiredCyberware")] 
		public CBool HasRequiredCyberware
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("timeToRemoveOccludedTarget")] 
		public CFloat TimeToRemoveOccludedTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("timeToLock")] 
		public CFloat TimeToLock
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeToUnlock")] 
		public CFloat TimeToUnlock
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("smartAudioEvents")] 
		public CArray<CName> SmartAudioEvents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("smartAudioEventsDelays")] 
		public CArray<CFloat> SmartAudioEventsDelays
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public gamesmartGunUIParameters()
		{
			Targets = new();
			Sight = new gamesmartGunUISightParameters { Center = new Vector2(), TargetableRegionSize = new Vector2(), ReticleSize = new Vector2() };
			CrosshairPos = new Vector2();
			SmartAudioEvents = new();
			SmartAudioEventsDelays = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

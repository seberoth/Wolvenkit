using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInt32FixedValueProvider : questIInt32ValueProvider
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public questInt32FixedValueProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

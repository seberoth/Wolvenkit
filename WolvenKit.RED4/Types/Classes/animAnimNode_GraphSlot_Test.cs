using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_GraphSlot_Test : animAnimNode_GraphSlot
	{
		[Ordinal(14)] 
		[RED("graph_TEST")] 
		public CResourceReference<animAnimGraph> Graph_TEST
		{
			get => GetPropertyValue<CResourceReference<animAnimGraph>>();
			set => SetPropertyValue<CResourceReference<animAnimGraph>>(value);
		}

		[Ordinal(15)] 
		[RED("copyAnimInputsAtAttachTime")] 
		public CBool CopyAnimInputsAtAttachTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_GraphSlot_Test()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

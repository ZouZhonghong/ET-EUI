
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class ESCommonUI_1AwakeSystem : AwakeSystem<ESCommonUI_1,Transform> 
	{
		public override void Awake(ESCommonUI_1 self,Transform transform)
		{
			self.uiTransform = transform;
		}
	}


	[ObjectSystem]
	public class ESCommonUI_1DestroySystem : DestroySystem<ESCommonUI_1> 
	{
		public override void Destroy(ESCommonUI_1 self)
		{
			self.DestroyWidget();
		}
	}
}

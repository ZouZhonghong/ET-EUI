
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Dlg_RolesViewComponentAwakeSystem : AwakeSystem<Dlg_RolesViewComponent> 
	{
		public override void Awake(Dlg_RolesViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class Dlg_RolesViewComponentDestroySystem : DestroySystem<Dlg_RolesViewComponent> 
	{
		public override void Destroy(Dlg_RolesViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}

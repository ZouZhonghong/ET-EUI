using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class Dlg_Roles :Entity,IAwake,IUILogic
	{

		public Dlg_RolesViewComponent View { get => this.Parent.GetComponent<Dlg_RolesViewComponent>();}

		public Dictionary<int, Scroll_Item_Role> ScrollItemRoles;

	}
}

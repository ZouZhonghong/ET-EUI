
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_ServerTest1DestroySystem : DestroySystem<Scroll_Item_ServerTest1> 
	{
		public override void Destroy( Scroll_Item_ServerTest1 self )
		{
			self.DestroyWidget();
		}
	}
}

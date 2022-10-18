
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class Dlg_RolesViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.RectTransform EG_BackGroundRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EG_BackGroundRectTransform == null )
     			{
		    		this.m_EG_BackGroundRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EG_BackGround");
     			}
     			return this.m_EG_BackGroundRectTransform;
     		}
     	}

		public UnityEngine.UI.Button EButton_CreateRoleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateRoleButton == null )
     			{
		    		this.m_EButton_CreateRoleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_CreateRole");
     			}
     			return this.m_EButton_CreateRoleButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_CreateRoleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CreateRoleImage == null )
     			{
		    		this.m_EButton_CreateRoleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_CreateRole");
     			}
     			return this.m_EButton_CreateRoleImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_CreateRoleText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_CreateRoleText == null )
     			{
		    		this.m_ELabel_CreateRoleText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_CreateRole/ELabel_CreateRole");
     			}
     			return this.m_ELabel_CreateRoleText;
     		}
     	}

		public UnityEngine.UI.Button EButton_DeleteRoleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_DeleteRoleButton == null )
     			{
		    		this.m_EButton_DeleteRoleButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_DeleteRole");
     			}
     			return this.m_EButton_DeleteRoleButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_DeleteRoleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_DeleteRoleImage == null )
     			{
		    		this.m_EButton_DeleteRoleImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_DeleteRole");
     			}
     			return this.m_EButton_DeleteRoleImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_DeleteRoleText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_DeleteRoleText == null )
     			{
		    		this.m_ELabel_DeleteRoleText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_DeleteRole/ELabel_DeleteRole");
     			}
     			return this.m_ELabel_DeleteRoleText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect ELoopScrollList_RolesLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELoopScrollList_RolesLoopVerticalScrollRect == null )
     			{
		    		this.m_ELoopScrollList_RolesLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"ELoopScrollList_Roles");
     			}
     			return this.m_ELoopScrollList_RolesLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Image EInputFieldImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EInputFieldImage == null )
     			{
		    		this.m_EInputFieldImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EInputField");
     			}
     			return this.m_EInputFieldImage;
     		}
     	}

		public TMPro.TextMeshProUGUI ElabelTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ElabelTextMeshProUGUI == null )
     			{
		    		this.m_ElabelTextMeshProUGUI = UIFindHelper.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"EInputField/text/Elabel");
     			}
     			return this.m_ElabelTextMeshProUGUI;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EG_BackGroundRectTransform = null;
			this.m_EButton_CreateRoleButton = null;
			this.m_EButton_CreateRoleImage = null;
			this.m_ELabel_CreateRoleText = null;
			this.m_EButton_DeleteRoleButton = null;
			this.m_EButton_DeleteRoleImage = null;
			this.m_ELabel_DeleteRoleText = null;
			this.m_ELoopScrollList_RolesLoopVerticalScrollRect = null;
			this.m_EInputFieldImage = null;
			this.m_ElabelTextMeshProUGUI = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_EG_BackGroundRectTransform = null;
		private UnityEngine.UI.Button m_EButton_CreateRoleButton = null;
		private UnityEngine.UI.Image m_EButton_CreateRoleImage = null;
		private UnityEngine.UI.Text m_ELabel_CreateRoleText = null;
		private UnityEngine.UI.Button m_EButton_DeleteRoleButton = null;
		private UnityEngine.UI.Image m_EButton_DeleteRoleImage = null;
		private UnityEngine.UI.Text m_ELabel_DeleteRoleText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_ELoopScrollList_RolesLoopVerticalScrollRect = null;
		private UnityEngine.UI.Image m_EInputFieldImage = null;
		private TMPro.TextMeshProUGUI m_ElabelTextMeshProUGUI = null;
		public Transform uiTransform = null;
	}
}

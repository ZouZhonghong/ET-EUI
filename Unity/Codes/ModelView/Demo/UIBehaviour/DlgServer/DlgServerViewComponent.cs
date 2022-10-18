
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgServerViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.RectTransform EGBackGroundRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EGBackGroundRectTransform == null )
     			{
		    		this.m_EGBackGroundRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EGBackGround");
     			}
     			return this.m_EGBackGroundRectTransform;
     		}
     	}

		public UnityEngine.UI.Button EButton_ConfirmButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_ConfirmButton == null )
     			{
		    		this.m_EButton_ConfirmButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Confirm");
     			}
     			return this.m_EButton_ConfirmButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_ConfirmImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_ConfirmImage == null )
     			{
		    		this.m_EButton_ConfirmImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Confirm");
     			}
     			return this.m_EButton_ConfirmImage;
     		}
     	}

		public UnityEngine.UI.Text ELabelText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabelText == null )
     			{
		    		this.m_ELabelText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_Confirm/ELabel");
     			}
     			return this.m_ELabelText;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect ELoopScrollList_ServerLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELoopScrollList_ServerLoopVerticalScrollRect == null )
     			{
		    		this.m_ELoopScrollList_ServerLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"ELoopScrollList_Server");
     			}
     			return this.m_ELoopScrollList_ServerLoopVerticalScrollRect;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EGBackGroundRectTransform = null;
			this.m_EButton_ConfirmButton = null;
			this.m_EButton_ConfirmImage = null;
			this.m_ELabelText = null;
			this.m_ELoopScrollList_ServerLoopVerticalScrollRect = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_EGBackGroundRectTransform = null;
		private UnityEngine.UI.Button m_EButton_ConfirmButton = null;
		private UnityEngine.UI.Image m_EButton_ConfirmImage = null;
		private UnityEngine.UI.Text m_ELabelText = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_ELoopScrollList_ServerLoopVerticalScrollRect = null;
		public Transform uiTransform = null;
	}
}

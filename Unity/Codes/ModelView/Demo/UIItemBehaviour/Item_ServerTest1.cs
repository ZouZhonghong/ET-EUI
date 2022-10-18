
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class Scroll_Item_ServerTest1 : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_ServerTest1 BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Image EImage_serverTestImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_EImage_serverTestImage == null )
     				{
		    			this.m_EImage_serverTestImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EImage_serverTest");
     				}
     				return this.m_EImage_serverTestImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EImage_serverTest");
     			}
     		}
     	}

		public TMPro.TextMeshProUGUI ELabel_serverTestTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_ELabel_serverTestTextMeshProUGUI == null )
     				{
		    			this.m_ELabel_serverTestTextMeshProUGUI = UIFindHelper.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"ELabel_serverTest");
     				}
     				return this.m_ELabel_serverTestTextMeshProUGUI;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"ELabel_serverTest");
     			}
     		}
     	}

		public UnityEngine.UI.Button EButton_serverTestButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_EButton_serverTestButton == null )
     				{
		    			this.m_EButton_serverTestButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_serverTest");
     				}
     				return this.m_EButton_serverTestButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_serverTest");
     			}
     		}
     	}

		public UnityEngine.UI.Image EButton_serverTestImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_EButton_serverTestImage == null )
     				{
		    			this.m_EButton_serverTestImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_serverTest");
     				}
     				return this.m_EButton_serverTestImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_serverTest");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EImage_serverTestImage = null;
			this.m_ELabel_serverTestTextMeshProUGUI = null;
			this.m_EButton_serverTestButton = null;
			this.m_EButton_serverTestImage = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Image m_EImage_serverTestImage = null;
		private TMPro.TextMeshProUGUI m_ELabel_serverTestTextMeshProUGUI = null;
		private UnityEngine.UI.Button m_EButton_serverTestButton = null;
		private UnityEngine.UI.Image m_EButton_serverTestImage = null;
		public Transform uiTransform = null;
	}
}

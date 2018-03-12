using UnityEngine;
using System.Collections;

public class PanelBase : MonoBehaviour {

	public string skinPath;
	public GameObject skin;//代表panel面板在场景中的物体
	public PanelLayer layer;
	public object[] args;
    private  GameObject currentPanelBk;//标记当前显示面板背景
   
	public virtual void Init(params object[] _args)
	{
		this.args = _args;
       // Debug.Log("init");
	}
	public virtual void OnShowing()
	{
	}
	public virtual void OnShowed(){
	}
	public virtual void Update(){
	}
	public virtual void OnClosing(){
	}
	public virtual void OnClosed(){
	}
    public virtual void OnHide(){
    }
	protected virtual void Close()
	{
		string name = this.GetType ().ToString ();
		PanelMgr.instance.ClosePanel (name);
	}
    public virtual void OnOpen()
    {
       
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuePl : PanelBase
{

    private Button startbt;
    private Button gameBt;
    private Button overBt;
    // Use this for initialization
    public override void Init(params object[] _args)
    {
        skinPath = "MenuePl";
        layer = PanelLayer.Tips;
    }

    // Update is called once per frame
    public override void OnShowing()
    {
        Transform skinTf = skin.transform;
        startbt = skinTf.Find("startBt").GetComponent<Button>();
        gameBt = skinTf.Find("gameBt").GetComponent<Button>();
        overBt = skinTf.Find("overBt").GetComponent<Button>();

		startbt.onClick.AddListener(OnStartBtClick);
		gameBt.onClick.AddListener(OnGameBtClick);
		overBt.onClick.AddListener(OnOverBtClick);
    }
	private void OnStartBtClick()
	{
		PanelMgr.instance.OpenPanel<StartPl>();
		PanelMgr.instance.HidePanel(PanelName.GamePanel);
		PanelMgr.instance.HidePanel(PanelName.overPanel);
	}
	private void OnGameBtClick()
	{
		PanelMgr.instance.OpenPanel<GamePl>();
		PanelMgr.instance.HidePanel(PanelName.StartPanel);
		PanelMgr.instance.HidePanel(PanelName.overPanel);
	}
	private void OnOverBtClick()
	{
		PanelMgr.instance.OpenPanel<OverPl>();
		PanelMgr.instance.HidePanel(PanelName.GamePanel);
		PanelMgr.instance.HidePanel(PanelName.StartPanel);
	}
}

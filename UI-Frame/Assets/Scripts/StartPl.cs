﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPl : PanelBase {
    private Button startBt;
	public override void Init(params object[] _args)
	{
		skinPath="StartPl";
		layer=PanelLayer.Start;
	}

	public override void OnShowing()
	{
		startBt=skin.transform.Find("startBt").GetComponent<Button>();
	    startBt.onClick.AddListener(OnStartBtClick);
	}

	private void OnStartBtClick()
	{
		Debug.Log("开始游戏");
	}

}

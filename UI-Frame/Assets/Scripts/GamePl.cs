﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePl : PanelBase {
    private Button gameBt;
	public override void Init(params object[] _args)
	{
		skinPath="GamePl";
		layer=PanelLayer.Panel;
	}

	public override void OnShowing()
	{
		gameBt=skin.transform.Find("gameBt").GetComponent<Button>();
	    gameBt.onClick.AddListener(OnGameBtClick);
	}

	private void OnGameBtClick()
	{
		Debug.Log("游戏中。。。");
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay : MonoBehaviour {

	public Transform player;
	public health UIBar;
	public GameObject gameOverUI;
	public GameObject gameReallyOverUI;
	public static Vector3 startPosition;
	private float fillAmount;

	void Awake(){
		startPosition = player.position;
		fillAmount = UIBar.healthBar.fillAmount;
		gameOverUI.SetActive(false);
	}

	public void Click(){
		if(health.i == 3){
			player.position = new Vector3(-81,10,-55); // puts character back at beginning of level
			health.i = 0;
			gameReallyOverUI.SetActive(false);
			moveCharacter.gameOver = false;
		}else{
			moveCharacter.gameOver = false;
			player.position = startPosition;
			UIBar.healthBar.fillAmount = fillAmount;
			gameOverUI.SetActive(false);
			health.i++;
		}
	}
}

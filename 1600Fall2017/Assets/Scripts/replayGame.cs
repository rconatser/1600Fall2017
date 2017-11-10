using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replayGame : MonoBehaviour {

	public Transform player;
	public updateHealth UIBar;
	public GameObject gameOverUI;
	public static Vector3 startPosition;
	private float fillAmount;

	void Awake(){
		startPosition = player.position;
		fillAmount = UIBar.healthBar.fillAmount;

	}

	public void Click(){
		characterControl.gameOver = false;
		player.position = startPosition;
		UIBar.healthBar.fillAmount = fillAmount;
		gameOverUI.SetActive(false);
	}
}

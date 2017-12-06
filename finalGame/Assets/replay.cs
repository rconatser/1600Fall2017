using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay : MonoBehaviour {

	public Transform player;
	public health UIBar;
	public GameObject gameOverUI;
	public static Vector3 startPosition;
	private float fillAmount;

	void Awake(){
		startPosition = player.position;
		fillAmount = UIBar.healthBar.fillAmount;
		gameOverUI.SetActive(false);

	}

	public void Click(){
		moveCharacter.gameOver = false;
		player.position = startPosition;
		UIBar.healthBar.fillAmount = fillAmount;
		gameOverUI.SetActive(false);
	}
}

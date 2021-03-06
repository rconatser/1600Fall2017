﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateHealth : MonoBehaviour {

	public Image healthBar;
	public GameObject gameOverUI;
	public Text coinNum;
	public Text endGameText;
	public int totalCoinValue, coinValue;
	public float powerLevel = 0.5f;
	public float upAmount = 0.01f;
	public enum powerUpType{ // like an array/list
		powerUp, // choice 1 label
		powerDown, // choice 2 label
		collectCoin,
		Win,
	}

	public powerUpType power; // will create a drop down in unity

	void OnTriggerEnter(){
		switch (power)
		{
			case powerUpType.powerUp:
				StartCoroutine(powerUpBar());
				break;

			case powerUpType.powerDown:
				StartCoroutine(powerDownBar());
				break;

			case powerUpType.collectCoin:
				StartCoroutine(collectCoin());
				break;
	
			case powerUpType.Win:
				endGame("You Win!");
				break;
		}

	}

	IEnumerator powerUpBar(){
		float tempAmount = healthBar.fillAmount + powerLevel;
		if(tempAmount > 1){
			tempAmount = 1;
		}

		while(healthBar.fillAmount < tempAmount){
			healthBar.fillAmount += upAmount; // adds the fillAmount from the barTime
			yield return new WaitForSeconds(upAmount); // waits for time (object)
		}
	}

	IEnumerator powerDownBar(){
		float tempAmount = healthBar.fillAmount - powerLevel;
		if(tempAmount < 0){
			tempAmount = 0;
		}

		while(healthBar.fillAmount > tempAmount){
			healthBar.fillAmount -= upAmount; // takes away the fillAmount from the barTime
			yield return new WaitForSeconds(upAmount); // waits for time (object)
		}

		if(healthBar.fillAmount == 0){ // will pop up when health is zero!
			endGame("Game Over");
		}
	}

	IEnumerator collectCoin(){
		totalCoinValue = int.Parse(coinNum.text);
		int tempAmount = totalCoinValue + coinValue;
		while(totalCoinValue <= tempAmount){
			coinNum.text = (totalCoinValue++).ToString();
			yield return new WaitForFixedUpdate();
		}
	}

	void endGame(string _text){
		endGameText.text = _text;
		gameOverUI.SetActive(true);
		characterControl.gameOver = true;
	}
}

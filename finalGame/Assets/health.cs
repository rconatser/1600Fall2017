using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {

	public Image healthBar;
	public GameObject gameOverUI;
	public Text endGameText;
	public Text gameReallyOver;
	public float powerLevel = 0.2f;
	public float upAmount = 0.01f;
	public static int i = 0;
	public Text numberLives;
	public GameObject gameReallyOverUI;
	public static int Lives = 3;
	public enum powerUpType{ // like an array/list
		powerUp, // choice 1 label
		powerDown, // choice 2 label
		Win
	}

	public powerUpType power; // will create a drop down in unity

	public void OnTriggerEnter(){
		switch (power)
		{
			case powerUpType.powerUp:
				StartCoroutine(powerUpBar());
				break;

			case powerUpType.powerDown:
				StartCoroutine(powerDownBar());
				break;
	
			case powerUpType.Win:
				endGame("You Win!");
				break;
		}
	}

	public IEnumerator powerUpBar(){
		float tempAmount = healthBar.fillAmount + powerLevel;
		if(tempAmount > 1){
			tempAmount = 1;
		}

		while(healthBar.fillAmount < tempAmount){
			healthBar.fillAmount += upAmount; // adds the fillAmount from the barTime
			yield return new WaitForSeconds(upAmount); // waits for time (object)
		}
	}

	public IEnumerator powerDownBar(){
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

	void Update(){
		numLives(Lives.ToString());
		if(Lives == 0){ // if lives ran out...
			moveCharacter.gameOver = true;
			gameReallyOver.text = "Starting from the beginning...";
			gameReallyOverUI.SetActive(true);
		}
	}

	public void endGame(string _text){
		endGameText.text = _text;
		gameOverUI.SetActive(true);
		moveCharacter.gameOver = true;
	}

	public void numLives(string _text){ // these integers are only available for use in this function.
		numberLives.text = _text;
	}
}




		/* BUGGY AF..... */
		// Color[] lifeColorsTwo = changeColor.lifeColors;
		// numberLives.color = lifeColorsTwo[i]; // assigns color to text
		// 	if(Lives > 0){
		// 		numberLives.text = _text;
		// 		numberLives.color = lifeColorsTwo[i]; // assigns color to text
		// 	}else{
		// 		numberLives.text = "0";
		// 	}

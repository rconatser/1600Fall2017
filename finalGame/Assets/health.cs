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
	public int[] Life = {3,2,1,0};
	public Color[] lifeColors = new Color[4]; // creates an array to hold the 4 Colors used for health bar color/lives text
	public Color[] groundColor = {Color.white, Color.yellow, Color.green, Color.cyan, Color.blue}; // creates another array for ground color later in level

	void Start(){
		lifeColors[0] = new Color(19f/255f,189f/255f,0f,1f); // deepish green color
		lifeColors[1] = new Color(189f/255f,189f/255f,0f,1f); // yellow-green color
		lifeColors[2] = new Color(221f/255f,127f/255f,0f,1f); // orange color
		lifeColors[3] = new Color(218f/255f,0f,0f,1f); // deepish red color
	}

	public enum powerUpType{ // like an array/list
		powerUp, // choice 1 label
		powerDown, // choice 2 label
		Win
	}

	public powerUpType power; // will create a drop down in unity

	public void OnTriggerEnter(){
		switch (power){
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
		if(i <= 3){
			numberLives.color = lifeColors[i];
			numLives(Life[i].ToString());
		}
		if(i == 3){ // if lives ran out... (would read 0)
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

	public void numLives(string _text){ 
		numberLives.text = _text;
	}
}

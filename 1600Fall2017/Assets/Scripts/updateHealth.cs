using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateHealth : MonoBehaviour {

	public Image healthBar;
	public float barTime = 0.1f;
	public float powerLevel = 0.1f;
	public float upAmount = 0.01f;
	public enum powerUpType{ // like an array/list
		powerUp, // choice 1 label
		powerDown // choice 2 label
	}

	public powerUpType powerUp; // will create a drop down in unity

	void OnTriggerEnter(){
		switch (powerUp)
		{
			case powerUpType.powerUp:
				StartCoroutine(powerUpBar());
				break;

			case powerUpType.powerDown:
				StartCoroutine(powerDownBar());
				break;
		}

	}

	IEnumerator powerUpBar(){
		float tempAmount = powerLevel;
		while(powerLevel < 1){
			healthBar.fillAmount += upAmount; // takes away the fillAmount from the barTime
			yield return new WaitForSeconds(barTime); // waits for time (object)
		}
	}

	IEnumerator powerDownBar(){
		float tempAmount = powerLevel;
		while(tempAmount > 0){
			tempAmount -= upAmount; // takes away the fillAmount from the barTime
			healthBar.fillAmount -= tempAmount;
			yield return new WaitForSeconds(barTime); // waits for time (object)
		}
	}
}

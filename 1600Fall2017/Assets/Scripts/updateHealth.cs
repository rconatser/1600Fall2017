using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateHealth : MonoBehaviour {

	public Image healthBar;
	public float barTime = 0.1f;
	public float powerLevel = 0.1f;
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
		while(healthBar.fillAmount < 1){
			healthBar.fillAmount += powerLevel; // takes away the fillAmount from the barTime
			yield return new WaitForSeconds(barTime); // waits for time (object)
		}
	}

	IEnumerator powerDownBar(){
		while(healthBar.fillAmount > 0){
			healthBar.fillAmount -= powerLevel; // takes away the fillAmount from the barTime
			yield return new WaitForSeconds(barTime); // waits for time (object)
		}
	}
}

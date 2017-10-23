using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateHealth : MonoBehaviour {

	public Image healthBar;
	public float barTime = 0.1f;

	void OnTriggerEnter(){
		StartCoroutine(UpdateBar());

		if(healthBar.fillAmount == 0){

		}
	}

	IEnumerator UpdateBar(){
		while(healthBar.fillAmount < 1){
			healthBar.fillAmount += barTime; // takes away the fillAmount from the barTime
			yield return new WaitForSeconds(barTime); // waits for time (object)
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour {
	public GameObject discoFloor;
	public int i = 0;
	public float colorChange = 1f; // 1 second
	public float wordOnOff = .1f;
	public static GameObject discoPanel, timePanel;
	public GameObject gameOverUI, gameReallyOverUI;
	public GameObject[] words = {discoPanel, timePanel};
	public Color[] groundColor = {Color.yellow, Color.green, Color.cyan, Color.blue, Color.white}; // creates another array for ground color later in level

	void OnTriggerEnter(){
		StartCoroutine(colorLoop());
	}
	IEnumerator colorLoop () {
		for(i = 0; i < groundColor.Length; i++){
			discoFloor.GetComponent<Renderer>().material.color = groundColor[i];
			yield return new WaitForSeconds(colorChange);
		}
		foreach(GameObject text in words){
			if(gameOverUI || gameReallyOverUI){
				text.SetActive(false);
			}
			text.SetActive(true);
			yield return new WaitForSeconds(wordOnOff);
			foreach(GameObject text1 in words){
				text1.SetActive(false);
				yield return new WaitForSeconds(wordOnOff);
			}
		}
	}
}

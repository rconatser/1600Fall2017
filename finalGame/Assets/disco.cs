﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour {
	public GameObject discoFloor;
	int i = 0;
	public float colorChange = 1f; // 1 second
	public Color[] groundColor = {Color.yellow, Color.green, Color.cyan, Color.blue, Color.white}; // creates another array for ground color later in level

	void OnTriggerEnter(){
		StartCoroutine(colorLoop());
	}
	IEnumerator colorLoop () {
		for(i = 0; i < groundColor.Length; i++){
			discoFloor.GetComponent<Renderer>().material.color = groundColor[i];
			yield return new WaitForSeconds(colorChange);
		}
	}
}

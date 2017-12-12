using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour {
	public GameObject discoFloor;
	int i = 0;
	//Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );;
	//public float timer;
	public Color[] groundColor = {Color.white, Color.yellow, Color.green, Color.cyan, Color.blue}; // creates another array for ground color later in level

	// Use this for initialization
	void OnTriggerEnter () {
	//	for(i = 0; i <= groundColor.Length; i++){
			foreach(Color color in groundColor){
				discoFloor.GetComponent<Renderer>().material.color = groundColor[i];
				i++;
				if(i>=groundColor.Length){
					i=0;
				}
			}	
	//	}
	}
}

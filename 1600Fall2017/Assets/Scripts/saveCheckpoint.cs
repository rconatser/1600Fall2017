using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveCheckpoint : MonoBehaviour {

	public GameObject player;
	Vector3 checkPoint;
	string[] playerPrefsTitles = {"CheckPointX", "CheckPointY", "CheckPointZ"};
	string[] position = {"X: ", "Y: ", "Z: "}; // doing this so it'll print "X, Y, or Z" before the actual stored data so it makes it easier to read.

	void OnTriggerEnter(){
		checkPoint = transform.position;
		for(int i = 0; i < playerPrefsTitles.Length; i++){
			PlayerPrefs.SetFloat(playerPrefsTitles[i], checkPoint[i]);
	//		print(position[i] + PlayerPrefs.GetFloat(playerPrefsTitles[i]));
		}
	}

	void Start(){
		for(int i = 0; i < playerPrefsTitles.Length; i++){
			checkPoint[i] = PlayerPrefs.GetFloat(playerPrefsTitles[i], checkPoint[i]);
		}
		player.transform.position = checkPoint;
	}
}

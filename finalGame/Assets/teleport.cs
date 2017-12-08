using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	public GameObject teleportOne;
	public Transform player;

	
	void OnTriggerEnter(){	
		if(teleportOne){
			player.position = new Vector3(-18,224,-55); // teleports player to new coordinates
		}
  	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {
	public Transform player;

	
	void OnTriggerEnter(){	
		player.position = new Vector3(-18,224,-55); // teleports player to new coordinates
		replay.startPosition = player.position; // logs teleported coordinates as new spawn coordinates
  	}
}

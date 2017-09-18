using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitch : MonoBehaviour {

	public string[] weapons; // [] makes it an array
	public int i = 0; // short for indexer

	public void Start(){
		switch(weapons[i]){
			case "Missile": 
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;

			default:
				print("You have no other weapons!");
				break;

		}
	}


}

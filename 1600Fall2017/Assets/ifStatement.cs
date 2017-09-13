using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

	public Text input;
	public string password = "password";
	bool canPlayGame = false;

	void Update(){
		if(input.text == password) {
			print("You know the password.");
			canPlayGame = true;
		}else{
			print("You don't know the password.");
		}
	
		if(canPlayGame){
			print("Playing the game.");
		}else{
			print("Can't play yet! Enter the correct password.");
		}
	}

}

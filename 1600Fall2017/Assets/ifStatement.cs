using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

	public Text input;
	public string password = "password";

	void Update(){
		if(input.text == password) {
			print("You know the password.");
		}else{
			print("You don't know the password.");
		}
	}

}

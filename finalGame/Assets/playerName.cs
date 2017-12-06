using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerName : MonoBehaviour {

	public InputField getName; // creates a field where the player can type an input.
	public GameObject introUI;

	public void Start(){
		getPlayerName(getName.text);
	}

	public string getPlayerName (string name){
		introUI.SetActive(true);
		moveCharacter.intro = true;

		if(name != ""){ // if player name input does not equal 'nothing' will return a name.
			moveCharacter.intro = false;
			introUI.SetActive(false);

		}else{
			name = "Player";
			moveCharacter.intro = false;
			introUI.SetActive(false);
		}
		return name;
	}
}

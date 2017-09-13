using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunGame : MonoBehaviour {

	public Toggle toggle;

	// Update is called once per frame
	void Update () {
		if(toggle.isOn){
			print("You can play!");
		}else{
			print("You cannot play. Sorry!");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColor : MonoBehaviour {
	
	public Color[] lifeColors = new Color[4]; // creates an array to hold the 4 Colors used for health bar color/lives text
	public Color[] groundColor = new Color[5]; // creates another array for ground color later in level

	void Start(){
		lifeColors[0] = new Color(114,255,189,255); // deepish green color
		lifeColors[1] = new Color(50,255,242,255); // yellow color
		lifeColors[2] = new Color(34,255,236,255); // orange color
		lifeColors[3] = new Color(0,255,210,255); // deepish red color

		groundColor[0] = Color.white;
		groundColor[1] = Color.yellow;
		groundColor[2] = Color.green;
		groundColor[3] = Color.cyan;
		groundColor[4] = Color.blue;
	}

}

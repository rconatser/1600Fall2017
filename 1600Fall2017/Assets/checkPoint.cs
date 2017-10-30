using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkPoint : MonoBehaviour {

	void OnTriggerEnter(){
		replayGame.startPosition = transform.position; // means it's going to be equal to our check point's position
		
	}

}

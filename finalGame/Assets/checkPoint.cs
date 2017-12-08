using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour {

	void OnTriggerEnter(){
		replay.startPosition = transform.position; // means it's going to be equal to our check point's position	
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vars : MonoBehaviour {

	public float health = 100;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(){
		health += 20; // adds 20 to health
	}
}

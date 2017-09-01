using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a parent class, it dictates what all child classes do unless overridden. 
All children classes inherite the functions/properties of the parent class.
*/


public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () {
		Die();
		Eat();
		Sleep();

	}

	void Die ()	{ // Declares function "Dies"
		print(this.name + " Dies");

	}

	void Eat ()	{ // Declares function "Eats"
		print(this.name + " Eats");

	}

	void Sleep () { // Declares function "Sleeps"
		print(this.name + " Sleeps");

	}

}

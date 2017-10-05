using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopeAndAccess : MonoBehaviour {

	private int health = 100; // defaults health to 100. The only thing that can see this is the script! (private)
	public int score = 100; // other scripts can see this. (public)
	void Box(){
		int newScore = 10; // can only be seen inside of Start(). CANNOT be "public int ___" within void functions.
		print(newScore);

		string thingTwo = "Silly!";




	}

	// scope is what functions can see. - if something is within something it's Private. 

}

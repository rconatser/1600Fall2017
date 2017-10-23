using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionsReturn : MonoBehaviour {
	public GameObject player;
	Vector3 coords;
	string[] position = {"X: ","Y: ","Z: "};
	public int i = 0;

	public void start(){

		getX(0); // runs getX function with parameter of 0. Hard coded...
		getY(1); // runs getY function with parameter of 1. Hard coded...
		getZ(2); // runs getZ function with parameter of 2. Hard coded...
		getCoords(0,0,0); // gets overall coords from player in a more efficient manor.
		damageDealt(27); // damage dealt to player function, 27 will assign itself to damage variable. Health is defaulted to 100.

	}

		float getX(float x){
			x = coords.x; // assigns X value to first slot in array
			return x;
		}

		float getY(float y){
			y = coords.y;
			return y;
		}

		float getZ(float z){
			z = coords.z;
			return z;
		}

		// more efficient way to get X, Y, and Z coordinates...
		float getCoords(float x, float y, float z){ // these integers are only available for use in this function.
			for(i = 0; i < position.Length; i++){
				coords[i] = PlayerPrefs.GetFloat(position[i], coords[i]);
			}
			return coords[];

		}

		int damageDealt(int damage, int health = 100){ // defaulting health to 100, will subtract damage amount from health amount
			return health - damage;
			if(health <= 0){
				print("you are dead!");
			}
		}

}
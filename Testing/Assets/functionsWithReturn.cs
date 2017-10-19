using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionsWithReturn : MonoBehaviour {
	public Transform player;
	Vector3 coords;
	public float x, y, z;
	string[] position = {"X: ","Y: ","Z: "};

	public void start(){

		getX(0); // runs getX function with parameter of 0. Hard coded...
		getY(1); // runs getY function with parameter of 1. Hard coded...
		getZ(2); // runs getZ function with parameter of 2. Hard coded...
		getCoords(0,5,7); // gets overall coords from player in a more efficient manor.
		damageDealt(27,56); // damage dealt to player function, 27 will assign itself to damage variable. Health is defaulted to 100.
		playerName("SuperCoolDude1999");


	}

		float getX(float x = 0){
			x = player.position.x; // assigns X value to first slot in array
			return x;
		}

		float getY(float y = 1){
			y = player.position.y;
			return y;
		}

		float getZ(float z = 2){
			z = player.position.z;
			return z;
		}

		// more efficient way to get X, Y, and Z coordinates...
		float getCoords(float x, float y, float z){ // these integers are only available for use in this function.
			for(int i = 0; i < position.Length; i++){
				coords[i] = PlayerPrefs.GetFloat(position[i], coords[i]);
			return x + y + z;
			}
		}

		float damageDealt(float damage, float health){ // defaulting health to 100, will subtract damage amount from health amount
			return health - damage;
				if(health <= 0){
					print("you are dead!");
				}
		}

		string playerName(string name){ // simple example
			return name;
		}

		


}

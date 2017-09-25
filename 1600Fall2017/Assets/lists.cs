using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lists : MonoBehaviour {


	public List<GameObject> myWeapons;

	void OnTriggerEnter(Collider _weapon) {
		myWeapons.Add(_weapon.gameObject);
		
	}





	// public List<string> myWeapons; // initializes a list, like an Array but you can edit/change it while the program is running.
	// public List<string> availWeapons;

	// void Start(){


	// 	availWeapons.Add("katana");
	// 	availWeapons.Add("glock");


	// 	foreach (var item in availWeapons){
	// 		myWeapons.Add(item); // 'stores data' to add weapons to inventory
	// 	}


	//  }
}

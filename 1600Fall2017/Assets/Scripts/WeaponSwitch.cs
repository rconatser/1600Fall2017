using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

    public List<GameObject> weapons;

    void OnTriggerEnter(Collider _weapon)
    {
        weapons.Add(_weapon.gameObject);
    }

	public void MyWeaponSwitch (int i){
		switch (weapons[i].name) // gets gameObject's name
		{
			// 	HARD CODING = NO 
			// case "MissileWeaponHolder":
			// 	print("Missile");
			// 	break;

			// case "PlasmaWeaponHolder":
			// 	print("Plasma");
			// 	break;

			// case "GunWeaponHolder":
			// 	print("Gun");
			// 	break;

			// default:
			// 	print("You have no other weapons.");
			// 	break;
		}
	}
}

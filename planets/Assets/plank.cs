using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plank : voidFunctions {

	public float damage = 5f;
	public float speed = 200f;

	void Update () {
		transform.Rotate(Vector3.right * Time.deltaTime * speed);
	}
}

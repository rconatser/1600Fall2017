using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doesDamage : MonoBehaviour {
	public float speed = 200f; // sets default speed

	void Update () {
		transform.Rotate(Vector3.right * Time.deltaTime * speed); // makes it spin
	}
}
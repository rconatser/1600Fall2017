using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doesDamage : MonoBehaviour {

	public float damage = 5f;
	public float speed = 200f;

	void Update () {
		transform.Rotate(Vector3.right * Time.deltaTime * speed); // makes it spin
		
	}
}
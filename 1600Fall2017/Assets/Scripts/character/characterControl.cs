using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour {

	public CharacterController characterController;
	public float gravity = 9.81f; // creates a gravity component, defaults to 9.81
	public float speed = 10;
	public float jumpForce = 100; // creates jump 
	public Vector3 move; // temp variable that will store temp data
	void Start () {
		
	}

	void FixedUpdate () {
		move.y = -gravity * Time.deltaTime; // will slow this down and make it coorelate with time

		if(characterController.isGrounded){ // looks to see if character is on ground first
			move.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // if so, can move

			if(Input.GetKeyDown("space")){ // if its on ground, can jump
				move.y += jumpForce * Time.deltaTime; // creates jumpforce (shoots up)
			}
		}
	
		characterController.Move(move);

	}
}

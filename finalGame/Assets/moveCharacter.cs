using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveCharacter : MonoBehaviour {
	public CharacterController characterController;
	public static bool gameOver; // by default bool is false
	public static bool intro;
	public float gravity = 9.81f; // creates a gravity component, defaults to 9.81
	public float speed = 50;
	public float jumpForce = 125; // creates jump 
	public string newName;
	public Vector3 move; // temp variable that will store temp data

	void Update () {
		move.y -= gravity * Time.deltaTime; // will slow this down and make it coorelate with time

		if(characterController.isGrounded && !gameOver && !intro){ // looks to see if character is on ground first
			move.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // if so, can move

			if(Input.GetKey(KeyCode.Space)){ // if its on ground, can jump
				move.y = jumpForce * Time.deltaTime; // creates jumpforce (shoots up)
			}
		}
		characterController.Move(move);

	}
}

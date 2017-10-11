using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public NavMeshAgent agent; // makes AI move, part of AI namespace
	public Transform player; // contain position data, named player

	
	// Update is called once per frame
	void Update () {
		agent.destination = player.position; // vector3(XYZ) assigns value of player's position
	}

	public void stun (float _speed){
		agent.speed = _speed;
		agent.acceleration = _speed;
		agent.destination = transform.position;
	}
}

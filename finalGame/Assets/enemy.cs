﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class enemy : MonoBehaviour {
 
  public NavMeshAgent agent; // makes AI move, part of AI namespace
  public Transform player; // contain position data, named player
 
  void Update () {
    agent.destination = player.position; // vector3(XYZ) assigns value of player's position
  }
}
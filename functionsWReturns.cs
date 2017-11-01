﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class functionsWReturns : MonoBehaviour {
  public GameObject player;
  Vector3 coords;
  string[] position = {"X: ","Y: ","Z: "};
  public int i = 0;
  public int newHealth;
  public Text input;
  public bool canPlay;
  public string user;
  public string pass;
  public Image healthBar;
 
  public void start(){
 
    getX(0); // runs getX function with parameter of 0. Hard coded...
    getY(1); // runs getY function with parameter of 1. Hard coded...
    getZ(2); // runs getZ function with parameter of 2. Hard coded...
    getCoords(0,0,0); // gets overall coords from player in a more efficient manor.
    damageDealt(27); // damage dealt to player function, 27 will assign itself to damage variable. Health is defaulted to 100.
    getDamage(5,100);
    getUsername("user");
    getPassword("pass");
    getPlayerName("playerOne");


  }
 
    float getX(float x){
        x = coords.x; // assigns X value to first slot in array
        return x;
    }
 
    float getY(float y){
        y = coords.y;
        return y;
    }
 
    float getZ(float z){
        z = coords.z;
        return z;
    }
 
    // more efficient way to get X, Y, and Z coordinates...
    float getCoords(float x, float y, float z){ // these integers are only available for use in this function.
        for(i = 0; i < position.Length; i++){
            coords[i] = PlayerPrefs.GetFloat(position[i], coords[i]);
        }
        return coords[i];
 
    }
 
    int damageDealt(int damage, int health = 100){ // defaulting health to 100, will subtract damage amount from health amount
        newHealth = health - damage;
        return newHealth;
        if(health <= 0){
            print("you are dead!");
        }
    }

    int getDamage(int damage, int health){
        damage = newHealth - health;
        return damage;
    }

    string getUsername(user){
        getPassword("pass");
        if(input.text == user && input.text == pass){
            canPlay = true;
        }
        return canPlay;
    }

    string getPassword(pass){
        getUsername("user");
        if(input.text == pass && input.text == user){
            canPlay = true;
        }
        return canPlay;
    }

    string getPlayerName(string playerName){
        playerName = input.text;
        return playerName;
    }

    float getHealth(float health){
        health = healthBar.fillAmount;
        return health;
    }
 
}
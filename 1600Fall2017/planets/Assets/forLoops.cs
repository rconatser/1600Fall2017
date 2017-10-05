using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forLoops : MonoBehaviour {

	public int numEnemies;
	public int numBots;
	public int numPlayers;
	public int level = 0;

	public bool gotPwrUp = false;
	public int health = 100;

	public int actionPoint = 6;
	public int movement;
	public int slowed = 5;
	public bool youSlow = false;
	public bool superBuff = false;
	public bool levelUp = false;


	void Start () {
		
		for(numEnemies = 0; numEnemies < numPlayers; numEnemies++){ // while the number of enemies is less than the number of players, it will add one to the enemy side. This will continue to run until no longer true!
			print("Add one to the opposing side! Total enemies now at: " + numEnemies);
		}

		for(numPlayers = 1; numPlayers <= 4; numPlayers++){ // checks to see if number of players is up to/equal to 4, if not adds one.
			print("Number of players: " + numPlayers);
		}

		for(numBots = 4; numPlayers <= 4; numBots--){ // will check to see if there are 0-4 players. If there are 0 players, there will be 4 bots. Minuses by one until all player slots are full.
			print("Number of bots currently in play: " + numBots);
		}

		for(level = 0; levelUp == true; level++){ // checks to see if levelUp bool becomes true, then adds One to level.
			print("Congratulations! You've leved up! You're now level " + level);
			levelUp = false; // sets levelup back to false so loop ends.
		}

		for(int powerUp = 50; gotPwrUp == true; health+=powerUp){ // adds powerup to health as long as gotPwrUp is true. 
			print("Got power up! Health now at " + health + "%.");
			gotPwrUp = false; // sets gotPwrUp back to false so it ends loop. 
		}

		for(int poison = 5; health > 0; health-=poison){ // minuses 5 from health as long as health is greater than zero
			print("You've been poisoned! Better find a power up. Your health is now at " + health + "%.");

			if(health == 0){
				print("You died! Cause of death: Poison."); // prints if poison causes player to die.
			}
		}

		youSlow = true; // so we can see the next for loop activate.

		for(movement = 20; youSlow == true && movement != 0; movement -= slowed){ // prints movement (in simplified terms) in reaction to minuses slowed amount from movement if YouSlow is true.
			print("You're slowed! -" + slowed + ", movement at " + movement); 
		}

		for(movement = 45; movement > 0 && actionPoint >= 0; actionPoint--){ // action points dictate how far you can move
			print("Running out of action points... " + actionPoint);
		}

		superBuff = true; // so we can see the next for loop activate.

		for(health = 1; health > 0 && superBuff == true; health+=100){
			print("SUUUPPPPEEERRRR BUFFFF! Health at " + health + "%.");
			superBuff = false; // sets superBuff back to false to end the loop
		}

		for(level = 10; levelUp == true; health+=100){ // if level is greater than 10 it will add 100 to health already existing.
			print("Super health boost! " + health);
		}


	}
}

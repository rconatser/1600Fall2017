using System.Collections;
 
using System.Collections.Generic;
 
using UnityEngine;
 

 
public class voidFunctions : MonoBehaviour {

	public int health = 100;
	public string[] playerFood = {"Apple(s)", "Banana(s)", "Grape(s)", "Chicken(s)", "Turkey(s)", "Cake(s)"};
  	public int[] foodCount = {2, 3, 1, 2, 6, 1};
	public bool killedPlayer; // adds true/false variable
	public int playerScore = 0; // defaults player's score to zero
	public int otherPlayerHealth = 100; // other player's health default to 100
    public float walkSpeed = 5f; // sets default walk speed to 5
    public int numArmor = 0; 
    public bool pwrDown;
    public bool pwrUp;

 
  //Im making most of my variables if not all public as I may use them in other scripts. If I wanted them to only be used in this script, I'd make it private.
  // void functions are functions that don't necessarily return anything

    public virtual void Start(){ // will call all of the void functions created below with their parameters if applicable
 
        heal("Health", 1);
 

 
        for(int i = 0; i < playerFood.Length; i++){
 
            eat(playerFood[i], foodCount[i]); // will print all food items and their quantities.
 
        }
 

		// calls the following functions and runs them if applicable. () are empty because I didn't specify specific perameters 
        die();
        damage();
        score();
        walk();
        sprint();
        shrink();
        grow();

		armor(3); // will add 75 to health 
		pScore(15); // will return 15.
		helloWorld("hi"); // has to put parameter for function to work
		playerName("password"); // will return "incorrect" because hard coded password.
		numPowerDowns(2);
		numPowerUps(3);
 

 
    }
 

 
    void heal(string potion, int amount){ // function with parameters. The two parameters must be true for this function to work
 
        print(this.name + " uses a " + " potion.");
          
		    if(health <= 50 && health > 0){ // if health is less than 50 and greater than 0 the potion will add 50 health points
                health += 50;
            }

            if(health < 100 && health > 50){ // if health is less than 100 and greater than 50 potion will cause health to equal 100 again.
                health = 100;
            }
        print(this.name + "'s health is now at " + health + ".");
    }
 

 
    void eat(string food, int amount){ // function with parameters. The two parameters must be true for this function to work
        print(this.name + " eats " + amount + " " + food + "."); // when player eats food will heal player
          
		    if(health < 90){
                health += 10;
            }

        print(this.name + "'s health is now at " + health + ".");
 
    }
 

 
    protected void die(){ // can be accessed by other classes derived by this one.
 
        if(health <= 0){ // if health reaches zero, player dies.
        print(this.name + " has died!");
        }
    }
 

 
    private void damage(){ // due to putting Private at the beginning, it causes it to only be seen by this script. 
 
        if(otherPlayerHealth == 0){
            print("Other player has died!");
            killedPlayer = true; // sets killed player to true for the main player, will pop up as 1 (or more) in the playerscore in score()
        }
    }
 

 
    public void score(){ // if player kills player, adds one to their score! -- can be seen by all scripts/classes associated
        if(killedPlayer == true){
            playerScore++;
            print(playerScore);
        }
    }
 

 
    void armor(int numArmor){
        if(numArmor > 0){
            numArmor*=25; // looks at number of armor pieces and multiplies that number by 25
            health += numArmor; // adds numArmor amount to health
            print("Due to " + numArmor + " pieces of armor, your health is at " + health);
        }
    }
 

 
    void walk(){ // just learning about grabbing input keys... Will figure out how to input this into actual movement soon!
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) ){
           // sees if player pressed the W, S, A, or D key(s). If so, it'll automatically have them walk at a speed of 5.
            walkSpeed = 5; 
 
        }
    }
 

 
    public void sprint(){ // just learning about grabbing input keys... Will figure out how to input this into actual movement soon!
	//will be seen by all classes
 
        if(Input.GetKeyDown(KeyCode.LeftShift)){ // sees if player holds down shift, changes speed to 10!
            walkSpeed = 10;
        }
    }
 

 
    public void shrink(){ // will see if user has received pwrDown
	//will be seen by all scripts

        if(pwrDown == true){
            transform.localScale += new Vector3(-0.5F, -0.5F, -0.5F); 
        } // looks at current scale of a game object, and transforms / scales it down by 0.5.
    }     // vector3 manipulates 3D vectors/points on game object
 

 
    public void grow(){
 
        if(pwrUp == true){
            transform.localScale += new Vector3(0.5F, 0.5F, 0.5F);
        }// looks at current scale of a game object, and transforms / scales it up by 0.5.
 
    }    // vector3 manipulates 3D vectors/points on game object
 

	private int numApples(int amount){ // this function will only be seen by this class
		int ret; // can only be seen by this function
		ret = amount+=5; // will return the amount of apples + 5. Should return 5 unless variable has been changed.
		return ret; // returns apple, this function would not work properly if return was not here! (hence void functions)
	}

	public int pScore(int score){ // this function can be seen by all scripts. Similar to the other player score function, but it returns it's data type.
		return score; // will return the player score! (declared int above)
	}

	string playerName(string _login){ // returns player's name. 
		if(_login == "playerOne"){
			return "Password is correct"; // will return the password ...with just this return, the function is unhappy!
		}else{
			return "Incorrect"; // will return Incorrect if typed incorrectly. When adding this return it garauntees that the function will return something, making it happy.
		}
	}

	string helloWorld(string hi){ // returns "hello"
		hi = "hello";
		return hi;
	}

	int numPowerUps(int powerUp){
		if(pwrUp == true){
			powerUp++;
			return powerUp; // returns at least 1.
		}else{
			return 0; // no powerup!
		}
	}

	int numPowerDowns(int powerDown){
		if(pwrDown == true){
			powerDown++; // adds one to power down
			return powerDown;
		}else{
			return 0; // no power downs
		}
	}




 
}
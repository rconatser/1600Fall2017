using UnityEngine;

public class PowerUp : MonoBehaviour {

	void OnTriggerEnter()
	{
		gameObject.SetActive(false); // Turns powerup off.
	}
	
}

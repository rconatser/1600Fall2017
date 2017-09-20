using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour {

	public bool canPlay = true;

	void Start(){
		StartCoroutine(playGame());
	}

	IEnumerator playGame(){
		while (canPlay){
			print("Playing");
			yield return new WaitForSeconds(0.1f);
		}
		
		print("End game");
	}

}

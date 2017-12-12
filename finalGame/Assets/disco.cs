using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour {
	public GameObject discoFloor;
	int i = 0;
	//Color newColor = Color.black;
	public Color[] groundColor = {Color.white, Color.yellow, Color.green, Color.cyan, Color.blue}; // creates another array for ground color later in level

	// Use this for initialization
	void FixedUpdate () {
		// for(i = 0; i <= groundColor.Length; i++){
		// 	groundColor[i] = new newColor(Random.Range, Random.Range, Random.Range, 1f);
		// }
		foreach(Color color in groundColor){
			discoFloor.GetComponent<Renderer>().material.color = color;
			i++;
			if(i==groundColor.Length){
				i=0;
			}
		}	
	}

	//  void Update () 
    //  {
    //      timer += Time.deltaTime;
    //      if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
    //      {
    //          // pick a random color
    //          Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
    //          // apply it on current object's material
    //          renderer.material.color = newColor;
    //          timer = 0;
    //      }
  
         
    //  }
}

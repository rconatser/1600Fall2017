using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {

    void Swim() { // Declare function "Swims"
        print(this.name + " Swims");
    }
    
    void Start() {
        Swim();
    }

}

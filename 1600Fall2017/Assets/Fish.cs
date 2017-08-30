using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {

    public override void Start() {
        base.Start();
        Swim();
    }

    void Swim() {
        print(this.name + " Swims");
    }

}

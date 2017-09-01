using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Chil

public class Bird : Animal {

// override start -> overrides what the parent class  says to do and replaces it with it's own function(s)
    public override void Start() { 
        base.Start(); // reintroduces original parent class behavior
        Fly();
    }

    void Fly() {
        print(this.name + " Flies");
    }
}

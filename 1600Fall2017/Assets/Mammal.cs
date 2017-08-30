using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {
    public override void Start() {
        base.Start();
        liveBirth();
    }

    void liveBirth() {
        print(this.name + "s birth children");
    }
}

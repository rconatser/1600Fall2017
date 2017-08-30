using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {
    public override void Start() {
        base.Start();
        Code();
    }

    void Code() {
        print(this.name + " Codes");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPolymorphism : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animal animal = new Animal();

        animal.Attack("carot", 1000f);

        Cat cat = new Cat();
        cat.Attack("carot", 500f);
	}

}

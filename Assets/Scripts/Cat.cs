using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{

    public new void Attack(string enemyName, float damage)
    {
        Debug.Log("CatAttack");
    }
}
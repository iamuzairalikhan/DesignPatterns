using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Bow weapon implementation.
//  example of adding functionality without modifying the existing structure.
public class Bow_OpenClosed : Weapon_OpenClosed
{
    public override void DealDamage()
    {
        Debug.Log("Bow fires an arrow for 30 damage.");
    }
}


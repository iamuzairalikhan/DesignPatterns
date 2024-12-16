using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gun weapon implementation.
// We add functionality by creating a new class, without modifying the base class.
public class Gun_OpenClosed : Weapon_OpenClosed
{
    public override void DealDamage()
    {
        Debug.Log("Gun shoots the enemy for 100 damage.");
    }
}


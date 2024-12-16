using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sword weapon implementation.
// We add functionality by creating a new class, without modifying the base class.
public class Sword_OpenClosed : Weapon_OpenClosed
{
    public override void DealDamage()
    {
        Debug.Log("Sword slashes the enemy for 50 damage.");
    }
}

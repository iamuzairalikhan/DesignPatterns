using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Example of using the weapons in a game.
public class PlayerCombat_OpenClosed : MonoBehaviour
{
    private Weapon_OpenClosed currentWeapon;

    void Start()
    {
        // Assign a weapon (could be set dynamically in-game)
        currentWeapon = new Sword_OpenClosed(); // Could also be Gun_OpenClosed or Bow_OpenClosed
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentWeapon.DealDamage(); // Calls the appropriate damage logic for the current weapon
        }
    }
}


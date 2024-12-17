using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player depends on abstraction (IWeapon_DIP) instead of concrete weapon classes
public class Player_DIP : MonoBehaviour
{
    private IWeapon_DIP weapon; // Dependency on the abstraction

    void Start()
    {
        // Default weapon: Sword
        EquipWeapon(gameObject.AddComponent<SwordWeapon_DIP>());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weapon?.Attack(); // Perform the weapon attack
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            // Switch to Gun dynamically
            EquipWeapon(gameObject.AddComponent<GunWeapon_DIP>());
            Debug.Log("Switched to Gun!");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // Switch to Gun dynamically
            EquipWeapon(gameObject.AddComponent<SwordWeapon_DIP>());
            Debug.Log("Switched to Gun!");
        }
    }

    // Method to equip a weapon (Dependency Injection)
    public void EquipWeapon(IWeapon_DIP newWeapon)
    {
        weapon = newWeapon;
    }
}


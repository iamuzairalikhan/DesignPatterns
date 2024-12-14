using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract base class for all weapons
public abstract class Weapon
{
    // Every weapon will have a Fire method.
    public abstract void Fire();
}

// Concrete implementation for a Pistol
public class Pistol : Weapon
{
    public override void Fire()
    {
        Debug.Log("Pistol: Bang Bang!");
    }
}

// Concrete implementation for a Shotgun
public class Shotgun : Weapon
{
    public override void Fire()
    {
        Debug.Log("Shotgun: Boom!");
    }
}

// Factory class to create weapons
public class WeaponFactory
{
    // Factory method to create a weapon based on type
    public Weapon CreateWeapon(string weaponType)
    {
        switch (weaponType)
        {
            case "Pistol":
                return new Pistol(); // Create a Pistol object
            case "Shotgun":
                return new Shotgun(); // Create a Shotgun object
            default:
                Debug.LogWarning("Unknown weapon type! Returning null.");
                return null; // Return null for unknown types
        }
    }
}

// Script to test the factory in Unity
public class FactoryExample : MonoBehaviour
{
    private void Start()
    {
        // Create an instance of the WeaponFactory
        WeaponFactory weaponFactory = new WeaponFactory();

        // Create a Pistol using the factory
        Weapon pistol = weaponFactory.CreateWeapon("Pistol");
        if (pistol != null) pistol.Fire(); // Outputs: "Pistol: Bang Bang!"

        // Create a Shotgun using the factory
        Weapon shotgun = weaponFactory.CreateWeapon("Shotgun");
        if (shotgun != null) shotgun.Fire(); // Outputs: "Shotgun: Boom!"

        // Attempt to create an unknown weapon
        Weapon unknown = weaponFactory.CreateWeapon("Laser");
        if (unknown == null) Debug.Log("No such weapon exists!");
    }
}

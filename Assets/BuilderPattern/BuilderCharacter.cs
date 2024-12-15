using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Represents the product to be built
public class BuilderCharacter
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public float Speed { get; private set; }
    public int Armor { get; private set; }

    // Set methods for each property
    public void SetName(string name)
    {
        Name = name;
    }

    public void SetHealth(int health)
    {
        Health = health;
    }

    public void SetSpeed(float speed)
    {
        Speed = speed;
    }

    public void SetArmor(int armor)
    {
        Armor = armor;
    }

    // Display the character's details
    public void DisplayStats()
    {
        Debug.Log($"Character Name: {Name}, Health: {Health}, Speed: {Speed}, Armor: {Armor}");
    }
}






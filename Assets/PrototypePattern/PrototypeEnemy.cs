using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The concrete prototype class
public class PrototypeEnemy : IPrototype<PrototypeEnemy>
{
    public string Name; // Enemy name
    public int Health;  // Enemy health
    public float Speed; // Enemy speed

    // Constructor to create a new enemy
    public PrototypeEnemy(string name, int health, float speed)
    {
        Name = name;
        Health = health;
        Speed = speed;
    }

    // Clone method to create a copy of the enemy
    public PrototypeEnemy Clone()
    {
        return new PrototypeEnemy(this.Name, this.Health, this.Speed);
    }

    // Method to display enemy details (for testing)
    public void DisplayDetails()
    {
        Debug.Log($"Enemy: {Name}, Health: {Health}, Speed: {Speed}");
    }
}



// The Prototype interface defines a method for cloning objects
public interface IPrototype<T>
{
    T Clone(); // The method to clone an object
}



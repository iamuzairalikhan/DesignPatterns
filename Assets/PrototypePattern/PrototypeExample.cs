using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script to demonstrate the Prototype Pattern
public class PrototypeExample : MonoBehaviour
{
    private void Start()
    {
        // Create the prototype enemy
        PrototypeEnemy baseEnemy = new PrototypeEnemy("Goblin", 100, 2.5f);

        // Clone and customize the first enemy
        PrototypeEnemy enemy1 = baseEnemy.Clone();
        enemy1.Name = "Goblin Warrior"; // Customize the name
        enemy1.Health = 150; // Customize the health
        enemy1.Speed = 3.0f; // Customize the speed
        enemy1.DisplayDetails();

        // Clone and customize the second enemy
        PrototypeEnemy enemy2 = baseEnemy.Clone();
        enemy2.Name = "Goblin Archer"; // Customize the name
        enemy2.Health = 80; // Customize the health
        enemy2.Speed = 4.0f; // Customize the speed
        enemy2.DisplayDetails();

        // Use the base enemy without modifications
        baseEnemy.DisplayDetails();
    }
}


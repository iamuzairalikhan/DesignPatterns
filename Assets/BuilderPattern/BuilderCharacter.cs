using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// The complex object to be built
public class BuilderCharacter
{
    public string Name { get; private set; } // Character's name
    public int Health { get; private set; } // Character's health
    public int Strength { get; private set; } // Character's strength
    public float Speed { get; private set; } // Character's speed

    // Private constructor to enforce creation through the Builder
    private BuilderCharacter() { }

    // Nested Builder class
    public class Builder
    {
        private BuilderCharacter _character = new BuilderCharacter();

        // Set the name of the character
        public Builder SetName(string name)
        {
            _character.Name = name;
            return this; // Return the Builder for method chaining
        }

        // Set the health of the character
        public Builder SetHealth(int health)
        {
            _character.Health = health;
            return this;
        }

        // Set the strength of the character
        public Builder SetStrength(int strength)
        {
            _character.Strength = strength;
            return this;
        }

        // Set the speed of the character
        public Builder SetSpeed(float speed)
        {
            _character.Speed = speed;
            return this;
        }

        // Build and return the fully configured Character object
        public BuilderCharacter Build()
        {
            return _character;
        }
    }

    // Method to display character's stats (for testing)
    public void DisplayStats()
    {
        Debug.Log($"Name: {Name}, Health: {Health}, Strength: {Strength}, Speed: {Speed}");
    }
}


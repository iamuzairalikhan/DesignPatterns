using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Concrete implementation of the character builder
public class CharacterBuilder : ICharacterBuilder
{
    private BuilderCharacter _character;

    public CharacterBuilder()
    {
        _character = new BuilderCharacter(); // Initialize a new character
    }

    public void SetName(string name)
    {
        _character.SetName(name); // Set the name property
    }

    public void SetHealth(int health)
    {
        _character.SetHealth(health); // Set the health property
    }

    public void SetSpeed(float speed)
    {
        _character.SetSpeed(speed); // Set the speed property
    }

    public void SetArmor(int armor)
    {
        _character.SetArmor(armor); // Set the armor property
    }

    public BuilderCharacter GetCharacter()
    {
        return _character; // Return the fully built character
    }
}




// Interface defining the steps for building a character
public interface ICharacterBuilder
{
    void SetName(string name);    // Step to set the character's name
    void SetHealth(int health);  // Step to set the character's health
    void SetSpeed(float speed);  // Step to set the character's speed
    void SetArmor(int armor);    // Step to set the character's armor
    BuilderCharacter GetCharacter();    // Retrieve the built character
}



// Director class to manage the building process
public class CharacterDirector
{
    private ICharacterBuilder _builder;

    public CharacterDirector(ICharacterBuilder builder)
    {
        _builder = builder; // Assign the builder
    }

    // Build a basic warrior character
    public void BuildWarrior()
    {
        _builder.SetName("Warrior");
        _builder.SetHealth(150);
        _builder.SetSpeed(5.0f);
        _builder.SetArmor(50);
    }

    // Build a fast scout character
    public void BuildScout()
    {
        _builder.SetName("Scout");
        _builder.SetHealth(80);
        _builder.SetSpeed(10.0f);
        _builder.SetArmor(20);
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Demonstration of the Builder Pattern in Unity
public class BuilderExample : MonoBehaviour
{
    private void Start()
    {
        // Create a builder
        ICharacterBuilder builder = new CharacterBuilder();

        // Use the director to construct a warrior
        CharacterDirector director = new CharacterDirector(builder);
        director.BuildWarrior();

        // Retrieve and display the built warrior
        BuilderCharacter warrior = builder.GetCharacter();
        warrior.DisplayStats();

        // Reuse the builder for a scout
        director.BuildScout();
        BuilderCharacter scout = builder.GetCharacter();
        scout.DisplayStats();
    }
}


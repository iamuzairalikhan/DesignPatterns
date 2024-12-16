using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Example script to create characters using the Builder
public class CharacterBuilderExample : MonoBehaviour
{
    private void Start()
    {
        // Create a default warrior character
        BuilderCharacter warrior = new BuilderCharacter.Builder()
            .SetName("Warrior")
            .SetHealth(200)
            .SetStrength(50)
            .SetSpeed(4.5f)
            .Build(); // Build the character
        warrior.DisplayStats();

        // Create a fast rogue character
        BuilderCharacter rogue = new BuilderCharacter.Builder()
            .SetName("Rogue")
            .SetHealth(100)
            .SetStrength(30)
            .SetSpeed(8.0f)
            .Build(); // Build the character
        rogue.DisplayStats();

        // Create a wizard with custom attributes
        BuilderCharacter wizard = new BuilderCharacter.Builder()
            .SetName("Wizard")
            .SetHealth(80)
            .SetStrength(15)
            .SetSpeed(3.0f)
            .Build(); // Build the character
        wizard.DisplayStats();
    }
}


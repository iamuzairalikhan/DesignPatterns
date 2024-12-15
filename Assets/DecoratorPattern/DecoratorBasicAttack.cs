using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorBasicAttack : IAbility
{
    public void Execute()
    {
        Debug.Log("Performing a basic attack!");
    }
}






// Base interface for all abilities
public interface IAbility
{
    void Execute(); // Define the action/behavior
}


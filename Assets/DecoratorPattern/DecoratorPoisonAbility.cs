using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorPoisonAbility : AbilityDecorator
{
    public DecoratorPoisonAbility(IAbility ability) : base(ability) { }

    public override void Execute()
    {
        base.Execute(); // Perform the base ability
        AddPoisonDamage(); // Add poison damage behavior
    }

    private void AddPoisonDamage()
    {
        Debug.Log("Added poison damage to the attack!");
    }
}


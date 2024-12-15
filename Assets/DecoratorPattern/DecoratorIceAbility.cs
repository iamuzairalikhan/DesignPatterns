using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorIceAbility : AbilityDecorator
{
    public DecoratorIceAbility(IAbility ability) : base(ability) { }

    public override void Execute()
    {
        base.Execute(); // Perform the base ability
        AddIceDamage(); // Add ice damage behavior
    }

    private void AddIceDamage()
    {
        Debug.Log("Added ice damage to the attack!");
    }
}


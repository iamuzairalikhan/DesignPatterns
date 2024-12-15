using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorFireAbility : AbilityDecorator
{
    public DecoratorFireAbility(IAbility ability) : base(ability) { }

    public override void Execute()
    {
        base.Execute(); // Perform the base ability
        AddFireDamage(); // Add fire damage behavior
    }

    private void AddFireDamage()
    {
        Debug.Log("Added fire damage to the attack!");
    }
}


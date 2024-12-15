using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityDecorator : IAbility
{
    protected IAbility _wrappedAbility; // The wrapped ability (can be another decorator)

    public AbilityDecorator(IAbility ability)
    {
        _wrappedAbility = ability;
    }

    public virtual void Execute()
    {
        _wrappedAbility.Execute(); // Call the wrapped ability's behavior
    }
}

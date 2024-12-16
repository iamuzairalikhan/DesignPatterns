using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A targeting system that works with ITargetable objects
public class AdapterTargetingSystem : MonoBehaviour
{
    public void AttackTarget(IAdaptableTargetable target)
    {
        Debug.Log("Attacking target at position: " + target.GetPosition());
        target.TakeDamage(20); // Apply damage
    }
}

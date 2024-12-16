using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The interface expected by the targeting system
public interface IAdaptableTargetable
{
    Vector3 GetPosition(); // Method to get the position of the target
    void TakeDamage(int damage); // Method to apply damage to the target
}

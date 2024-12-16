using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for all weapons.
// Related to "Open/Closed" principle of SOLID.
public abstract class Weapon_OpenClosed : MonoBehaviour
{
    // Each weapon will have its own way to deal damage.
    public abstract void DealDamage();
}


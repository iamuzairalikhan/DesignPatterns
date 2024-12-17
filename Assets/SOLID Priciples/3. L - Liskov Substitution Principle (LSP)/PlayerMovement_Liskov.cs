using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for player movement.
// Related to "Liskov Substitution" principle of SOLID.
public abstract class PlayerMovement_Liskov : MonoBehaviour
{
    // Abstract method for movement
    public abstract void Move();
}

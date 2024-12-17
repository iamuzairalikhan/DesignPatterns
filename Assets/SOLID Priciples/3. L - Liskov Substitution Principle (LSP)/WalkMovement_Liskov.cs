using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Walking movement implementation.
public class WalkMovement_Liskov : PlayerMovement_Liskov
{
    public override void Move()
    {
        Debug.Log("Player is walking on the ground.");
    }
}


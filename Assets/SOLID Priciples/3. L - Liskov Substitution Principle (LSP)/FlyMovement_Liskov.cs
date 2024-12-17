using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Flying movement implementation.
public class FlyMovement_Liskov : PlayerMovement_Liskov
{
    public override void Move()
    {
        Debug.Log("Player is flying in the air.");
    }
}


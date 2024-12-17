using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Main player script that uses the movement system.
public class Player_Liskov : MonoBehaviour
{
    private PlayerMovement_Liskov movement;

    void Start()
    {
        // Assign default movement (Walking)
        movement = gameObject.AddComponent<WalkMovement_Liskov>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement.Move();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Switch movement dynamically to Fly
            Destroy(movement);
            movement = gameObject.AddComponent<FlyMovement_Liskov>();
            Debug.Log("Switched to Fly Movement!");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Switch movement dynamically to Fly
            Destroy(movement);
            movement = gameObject.AddComponent<WalkMovement_Liskov>();
            Debug.Log("Switched to Walk Movement!");
        }
    }
}


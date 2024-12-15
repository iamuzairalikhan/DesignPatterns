using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerController playerController;

    void Start()
    {
        // Set the initial movement strategy to Walk
        playerController.SetMovementStrategy(new WalkMovement());
    }

    void Update()
    {
        // You can switch to Running or Flying by pressing keys (e.g., 'R' for running, 'F' for flying)
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerController.SetMovementStrategy(new RunMovement());
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            playerController.SetMovementStrategy(new WalkMovement());
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            playerController.SetMovementStrategy(new FlyMovement());
        }

        // The movement will now be controlled by arrow keys within the current movement strategy
    }
}

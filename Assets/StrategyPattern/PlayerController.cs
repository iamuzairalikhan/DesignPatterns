using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private IMovementStrategy movementStrategy;

    // Set the movement strategy at runtime
    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }

    void Update()
    {
        if (movementStrategy != null)
        {
            movementStrategy.Move(transform);
        }
    }
}

//Interface for movement
public interface IMovementStrategy
{
    void Move(Transform playerTransform);
}


// Walking Strategy
public class WalkMovement : IMovementStrategy
{
    public void Move(Transform playerTransform)
    {
        float moveSpeed = 2f;  // Walking speed
        float horizontal = Input.GetAxis("Horizontal");  // Left/Right arrow
        float vertical = Input.GetAxis("Vertical");  // Up/Down arrow

        // Move player based on arrow key input
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;
        playerTransform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}


// Running Strategy
public class RunMovement : IMovementStrategy
{
    public void Move(Transform playerTransform)
    {
        float moveSpeed = 10f;  // Running speed
        float horizontal = Input.GetAxis("Horizontal");  // Left/Right arrow
        float vertical = Input.GetAxis("Vertical");  // Up/Down arrow

        // Move player based on arrow key input
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;
        playerTransform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}


// Flying Strategy
public class FlyMovement : IMovementStrategy
{
    public void Move(Transform playerTransform)
    {
        float moveSpeed = 3f;  // Flying speed
        float horizontal = Input.GetAxis("Horizontal");  // Left/Right arrow
        float vertical = Input.GetAxis("Vertical");  // Up/Down arrow

        // Use the Y-axis for vertical movement (flying up/down) along with horizontal movement
        Vector3 moveDirection = new Vector3(horizontal, vertical, 0).normalized;
        playerTransform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}




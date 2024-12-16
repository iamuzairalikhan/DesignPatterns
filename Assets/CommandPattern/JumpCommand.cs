using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// A concrete command for making the player jump
public class JumpCommand : ICommand
{
    private Transform _playerTransform; // Reference to the player
    private float _jumpHeight;          // Height of the jump

    public JumpCommand(Transform playerTransform, float jumpHeight)
    {
        _playerTransform = playerTransform;
        _jumpHeight = jumpHeight;
    }

    // Execute the jump
    public void Execute()
    {
        _playerTransform.position += Vector3.up * _jumpHeight;
        Debug.Log("Player jumped to: " + _playerTransform.position);
    }

    // Undo the jump
    public void Undo()
    {
        _playerTransform.position -= Vector3.up * _jumpHeight;
        Debug.Log("Jump undone. Player position: " + _playerTransform.position);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A concrete command for moving the player
public class MoveCommand : ICommand
{
    private Transform _playerTransform; // Reference to the player
    private Vector3 _direction;         // Direction to move
    private float _distance;            // Distance to move

    public MoveCommand(Transform playerTransform, Vector3 direction, float distance)
    {
        _playerTransform = playerTransform;
        _direction = direction;
        _distance = distance;
    }

    // Execute the move
    public void Execute()
    {
        _playerTransform.position += _direction * _distance;
        Debug.Log("Player moved to: " + _playerTransform.position);
    }

    // Undo the move
    public void Undo()
    {
        _playerTransform.position -= _direction * _distance;
        Debug.Log("Move undone. Player position: " + _playerTransform.position);
    }
}

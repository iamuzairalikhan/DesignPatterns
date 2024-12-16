using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles player input and executes commands
public class CommandInputHandler : MonoBehaviour
{
    private Transform _playerTransform;               // Reference to the player
    private Stack<ICommand> _commandHistory;          // Stores executed commands for undo functionality

    private void Start()
    {
        _playerTransform = GameObject.Find("Player").transform; // Get the player GameObject
        _commandHistory = new Stack<ICommand>();               // Initialize the command history
    }

    private void Update()
    {
        // Move forward
        if (Input.GetKeyDown(KeyCode.W))
        {
            ExecuteCommand(new MoveCommand(_playerTransform, Vector3.forward, 1f));
        }

        // Move backward
        if (Input.GetKeyDown(KeyCode.S))
        {
            ExecuteCommand(new MoveCommand(_playerTransform, Vector3.back, 1f));
        }

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExecuteCommand(new JumpCommand(_playerTransform, 2f));
        }

        // Undo last action
        if (Input.GetKeyDown(KeyCode.Z))
        {
            UndoCommand();
        }
    }

    // Execute a command and add it to the history
    private void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    // Undo the last executed command
    private void UndoCommand()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
    }
}


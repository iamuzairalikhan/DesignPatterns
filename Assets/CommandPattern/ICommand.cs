using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Command interface that all commands will implement
public interface ICommand
{
    void Execute(); // Perform the action
    void Undo();    // Undo the action (optional, for reversibility)
}


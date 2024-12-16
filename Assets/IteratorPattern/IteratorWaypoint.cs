using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Represents a waypoint in the game
public class IteratorWaypoint
{
    public Vector3 Position { get; private set; } // Stores the position of the waypoint

    public IteratorWaypoint(Vector3 position)
    {
        Position = position;
    }
}




// Defines the interface for a collection that can return an iterator
public interface IIterable<T>
{
    IIterator<T> GetIterator();  // Returns an iterator for the collection
}



// Defines the interface for iterating through a collection
public interface IIterator<T>
{
    bool HasNext();  // Checks if there are more elements
    T Next();        // Retrieves the next element
}

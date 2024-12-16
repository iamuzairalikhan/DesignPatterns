using System.Collections;
using System.Collections.Generic;

// Implements the iterator for the waypoint collection
public class IteratorWaypointIterator : IIterator<IteratorWaypoint>
{
    private List<IteratorWaypoint> _waypoints; // The list of waypoints to iterate through
    private int _currentIndex = 0;     // Tracks the current index

    public IteratorWaypointIterator(List<IteratorWaypoint> waypoints)
    {
        _waypoints = waypoints;
    }

    // Checks if there are more waypoints
    public bool HasNext()
    {
        return _currentIndex < _waypoints.Count;
    }

    // Retrieves the next waypoint
    public IteratorWaypoint Next()
    {
        return HasNext() ? _waypoints[_currentIndex++] : null;
    }
}


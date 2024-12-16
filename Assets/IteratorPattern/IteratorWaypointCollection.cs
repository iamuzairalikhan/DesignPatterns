using System.Collections;
using System.Collections.Generic;

// A collection of waypoints that implements the iterable interface
public class IteratorWaypointCollection : IIterable<IteratorWaypoint>
{
    private List<IteratorWaypoint> _waypoints = new List<IteratorWaypoint>();

    // Adds a waypoint to the collection
    public void AddWaypoint(IteratorWaypoint waypoint)
    {
        _waypoints.Add(waypoint);
    }

    // Returns an iterator for the waypoints
    public IIterator<IteratorWaypoint> GetIterator()
    {
        return new IteratorWaypointIterator(_waypoints);
    }
}


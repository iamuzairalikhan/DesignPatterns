using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles the movement of a game object through waypoints
public class IteratorWaypointMover : MonoBehaviour
{
    private IteratorWaypointCollection _waypointCollection; // The collection of waypoints
    private IIterator<IteratorWaypoint> _iterator;          // The iterator for the waypoints
    private Transform _playerTransform;            // The player or object to move
    public float Speed = 2f;                       // Movement speed

    private void Start()
    {
        // Reference to the player or object
        _playerTransform = this.transform;

        // Initialize the waypoints
        _waypointCollection = new IteratorWaypointCollection();
        _waypointCollection.AddWaypoint(new IteratorWaypoint(new Vector3(0, 0, 0)));
        _waypointCollection.AddWaypoint(new IteratorWaypoint(new Vector3(3, 0, 0)));
        _waypointCollection.AddWaypoint(new IteratorWaypoint(new Vector3(6, 0, 0)));
        _waypointCollection.AddWaypoint(new IteratorWaypoint(new Vector3(9, 0, 0)));
        _waypointCollection.AddWaypoint(new IteratorWaypoint(new Vector3(12, 0, 0)));
        _waypointCollection.AddWaypoint(new IteratorWaypoint(new Vector3(15, 0, 0)));

        // Get the iterator
        _iterator = _waypointCollection.GetIterator();
    }

    private void Update()
    {
        // Move towards the current waypoint
        if (_iterator.HasNext())
        {
            IteratorWaypoint currentWaypoint = _iterator.Next();
            StartCoroutine(MoveToWaypoint(currentWaypoint.Position));
        }
    }

    private IEnumerator MoveToWaypoint(Vector3 target)
    {
        while (Vector3.Distance(_playerTransform.position, target) > 0.1f)
        {
            _playerTransform.position = Vector3.MoveTowards(_playerTransform.position, target, Speed * Time.deltaTime);
            yield return null;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MVCCounterModel
{
    private int _counter; // Stores the current counter value

    // Event to notify changes in the counter value
    public event Action<int> OnCounterChanged;

    // Get the current counter value
    public int GetCounter()
    {
        return _counter;
    }

    // Increase the counter value
    public void Increment()
    {
        _counter++;
        NotifyCounterChanged();
    }

    // Decrease the counter value
    public void Decrement()
    {
        _counter--;
        NotifyCounterChanged();
    }

    // Reset the counter value
    public void Reset()
    {
        _counter = 0;
        NotifyCounterChanged();
    }

    // Notify subscribers that the counter value has changed
    private void NotifyCounterChanged()
    {
        OnCounterChanged?.Invoke(_counter);
    }
}


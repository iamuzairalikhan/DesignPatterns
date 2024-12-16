using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVCCounterController : MonoBehaviour
{
    private MVCCounterModel _model;   // Reference to the model
    private MVCCounterView _view;     // Reference to the view

    private void Start()
    {
        // Initialize the model and view
        _model = new MVCCounterModel();
        _view = GetComponent<MVCCounterView>();

        // Subscribe to model's counter change event
        _model.OnCounterChanged += _view.UpdateCounterDisplay;

        // Attach button click events to controller methods
        _view.IncrementButton.onClick.AddListener(OnIncrementButtonClicked);
        _view.DecrementButton.onClick.AddListener(OnDecrementButtonClicked);
        _view.ResetButton.onClick.AddListener(OnResetButtonClicked);

        // Initialize the view with the current counter value
        _view.UpdateCounterDisplay(_model.GetCounter());
    }

    // Handles increment button click
    private void OnIncrementButtonClicked()
    {
        _model.Increment();
    }

    // Handles decrement button click
    private void OnDecrementButtonClicked()
    {
        _model.Decrement();
    }

    // Handles reset button click
    private void OnResetButtonClicked()
    {
        _model.Reset();
    }
}

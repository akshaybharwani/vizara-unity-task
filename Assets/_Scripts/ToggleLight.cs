using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

    #region Public Variables

    // Reference to hold the light
    public Light light;

    #endregion

    #region Private Variables

    // Reference for the Light on status
    private bool _on;

    #endregion
    
    /// <summary>
    /// Which triggers a function based on Player's input
    /// after verifying its Position.
    /// </summary>
    /// <param name="collider"></param>
    void OnTriggerStay(Collider collider) {
        // Checks for the Player, if the Key is Pressed
        // and if the Light is on or not
        if (collider.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && !_on)
        {
            // Turns Light on
            light.enabled = true;
            _on = true;
        }
        else if (collider.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && _on)
        {
            // Turns Light off
            light.enabled = false;
            _on = false;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

    public Light light;
    private bool _on = false;

    // Use this for initialization
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
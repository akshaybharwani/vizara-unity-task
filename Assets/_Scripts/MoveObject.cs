using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    #region Public Variables

    // Reference to hold the Temporary Parent that the object
    // to be moved is going to be attached to
    public GameObject tempParent;

    public Transform guide;

    #endregion

    #region Private Variables

    // Reference to hold the object to be moved
    private GameObject item;
    
    private Rigidbody itemRigidbodyComponent;

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        item = gameObject;
        
        // Set Reference to Object Rigidbody component
        itemRigidbodyComponent = item.GetComponent<Rigidbody>();

        // Initially set Use Gravity for the object to be true
        // so that it's stationary
        itemRigidbodyComponent.useGravity = true;
    }

    private void OnMouseDown()
    {
        toggleObjectRigidbody(itemRigidbodyComponent, true);
        
        // Set Object's Transform to Guide's Transform
        item.transform.position = guide.position;
        item.transform.rotation = guide.rotation;
        
        // Attach Object to the Temporary Parent
        item.transform.parent = tempParent.transform;
    }

    void OnMouseUp()
    {
        toggleObjectRigidbody(itemRigidbodyComponent, false);
        
        // Remove the Parent
        item.transform.parent = null;
        
        // Assign Guide's Position to Object's Position
        item.transform.position = guide.position;
    }

    /// <summary>
    /// Function which toggles a Rigidbody's
    /// gravity and iskinematic values
    /// </summary>
    /// <param name="rigidbodyComponent"></param>
    void toggleObjectRigidbody(Rigidbody rigidbodyComponent, bool value)
    {
        itemRigidbodyComponent.useGravity = !value;
        itemRigidbodyComponent.isKinematic = value;
    }
}

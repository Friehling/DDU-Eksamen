using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    public float width = 2.5f;
    public float height = 2.5f;
    public float depth = 2.5f;
    public TriggerController controller;

    void OnTriggerEnter(Collider other)
    {
        // Check if the other GameObject has a BoxCollider component
        BoxCollider boxCollider = other.GetComponent<BoxCollider>();
        if (boxCollider != null)
        {
            Vector3 size2 = new Vector3(width, height, depth);
            // Get the size of the box collider
            Vector3 size1 = other.transform.localScale;

            
            if (size1 == size2 )
            {
                Debug.Log("Equal");
                controller.ActivateTrigger();
                
            }      
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.ClearDeveloperConsole();
        controller.DeactivateTrigger();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    public GameObject wall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger")
        {
            
            wall.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Trigger")
        {
            wall.SetActive(true);
        }
    }
}

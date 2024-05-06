using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public int triggercount = 0;
    public GameObject GameObject;

    public void ActivateTrigger()
    {
        
        triggercount++;
        if (triggercount == 5)
        {
            Debug.Log("The door opens");
            GameObject.SetActive(false);
        }
    }
    public void DeactivateTrigger()
    {
        if (triggercount > 0)
        {
            triggercount--;
        }
        
    }
    
}

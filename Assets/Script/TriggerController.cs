using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerController : MonoBehaviour
{
    public int triggercount = 0;
    public GameObject GameObject;
    public TMP_Text textMeshPro;
    public GameObject textContainer;

   

    public void ActivateTrigger()
    {
        
        triggercount++;
        if (triggercount == 5)
        {
            textContainer.SetActive(true);
            GameObject.SetActive(false);

        }
    }
    
}

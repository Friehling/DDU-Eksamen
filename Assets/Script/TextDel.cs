using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextDel : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public GameObject textContainer;
    public void OnTriggerEnter(Collider other)
    {
        textContainer.SetActive(false); 
    }

    
}

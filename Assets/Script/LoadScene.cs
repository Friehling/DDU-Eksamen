using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public GameObject button;
    public string EndScreen;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(loadScene);
    }
    void loadScene()
    {
        SceneManager.LoadScene(EndScreen);
    }

}

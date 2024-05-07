using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    public string sceneName; // The name of the scene to load

    // This function is called when the button is clicked
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName); // Load the specified scene
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnArrayEnd : MonoBehaviour
{
    public string sceneName; // The name of the scene to load
    private test otherScript; // Reference to the script where 'lines' exist

    private void Start()
    {
        // Find and store a reference to the script where 'lines' exist
        otherScript = FindObjectOfType<test>();
    }

    private void Update()
    {
        ChangeScene();
    }

    // This function is called when the button is clicked
    public void ChangeScene()
    {
        if (otherScript != null && otherScript.lines != null && otherScript.lines.Length > 0)
        {
            // Check if we've reached the end of the array
            if (otherScript.stringIndex > otherScript.lines.Length)
            {
                SceneManager.LoadScene(sceneName); // Load the specified scene
            }
        }
    }
}
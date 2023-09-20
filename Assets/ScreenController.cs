using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScreenController : MonoBehaviour
{
    //public string[] sceneNames; // An array to hold the names of your scenes.
    //public TextMeshProUGUI buttonText; // Reference to your TextMeshPro button text.

    //private int currentSceneIndex = 0;

    private void Start()
    {
        // Ensure that the currentSceneIndex is within bounds.
        //currentSceneIndex = Mathf.Clamp(currentSceneIndex, 0, sceneNames.Length - 1);

        // Load the initial scene.
        //LoadScene(currentSceneIndex);
    }

    /*
    public void LoadNextScene()
    {
        currentSceneIndex = (currentSceneIndex + 1)// % sceneNames.Length;
        LoadScene(currentSceneIndex);
    }
    */

    public void LoadScene(string sceneName)
    {
        // Load the selected scene by its name.
        //SceneManager.LoadScene(sceneNames[index]);
        SceneManager.LoadScene(sceneName);

        // Update the button text.
        //buttonText.text = "Switch to " + sceneNames[index];
    }
}

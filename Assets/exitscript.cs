using UnityEngine;
using UnityEngine.SceneManagement;

public class exitscript : MonoBehaviour
{  
    public string sceneToLoadOnExit = "Exit";
    void ExitGame()
        {
            // Implement your win game logic here
            Debug.Log("You Exited!");
            ReloadScene();
            // Example: Load a new scene
            // UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");

        }
         void ReloadScene()
    {
        SceneManager.LoadScene(sceneToLoadOnExit);
    }

}

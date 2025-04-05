using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public string sceneToLoadOnLose = "MainMenu1"; // Name of the scene to load on game over
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Or whatever tag your player has
        {
            // Code to trigger the game over sequence
            // For example, reload the scene or load a game over screen
            Debug.Log("Player triggered the Boss you lost!");
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(sceneToLoadOnLose);
    }
}

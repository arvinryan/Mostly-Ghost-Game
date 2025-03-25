using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private string SaveScene;

    public void NewGameButton()
    {
        SceneManager.LoadScene (SaveScene);
    }

    public void LoadGameButton()
    {
        if(PlayerPrefs.HasKey("LevelSaved"))
        {
            string levelToLoad = PlayerPrefs.GetString("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
        }
    }

}

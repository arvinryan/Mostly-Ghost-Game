using UnityEngine;
using UnityEngine.SceneManagement;
public class ContinueButton : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update () {
       // if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (GameIsPaused)
       //     {
        //        Resume();
        //    } else
        //    {
        //        Pause();
       //     }
       // }
    }
    void Continue(){
        SceneManager.LoadScene("SampleScene");
    }


    void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}

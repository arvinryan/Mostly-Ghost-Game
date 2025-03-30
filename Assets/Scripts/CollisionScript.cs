using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision objectCollidedWith)
    {
        if (objectCollidedWith.gameObject.tag == "Player")
        {
            Debug.Log("Destroying Enemy and losing a life!");

            GameManagerScript.Instance.SubtractLives(1);// subtract life
            Destroy(this.gameObject); // destroy self

            if (GameManagerScript.Instance.GameOver())
            {
                //destroy the object that collided with it if no lives left
                Destroy(objectCollidedWith.gameObject);
                //reload the scene
                SceneManager.LoadScene("LevelSample");
            }
        }
    }
}

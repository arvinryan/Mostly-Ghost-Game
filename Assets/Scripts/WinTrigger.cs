    using UnityEngine;

    public class WinTrigger : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            // Check if the entering object is the player (using tags, for example)
            if (other.CompareTag("Player")) // Replace "Player" with your player's tag
            {
                // Trigger the win condition
                WinGame();
            }
        }

        void WinGame()
        {
            // Implement your win game logic here
            Debug.Log("You got the Blue Orb from the Enemies, Good Job!");
            Debug.Log("You Win!");
            // Example: Load a new scene
            // UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
        }
    }

using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    // OnTriggerEnter is called when another collider enters the trigger.
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player or relevant object.
        // You can customize this condition based on your game setup.
        if (other.CompareTag("Player"))
        {
            // Restart the game by reloading the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}


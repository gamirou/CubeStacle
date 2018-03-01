using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 5.5f;

    public GameObject completeLevelUI;
    public GameObject restartLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        Invoke("LoadNextLevel", 2f);
    }

    void LoadNextLevel()
    {
        // Add another scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;

            // Restarting game
            // Has a slight delay
            restartLevelUI.SetActive(true);
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

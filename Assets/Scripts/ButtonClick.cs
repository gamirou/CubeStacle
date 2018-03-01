using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene("level01");
    }

    public void QuitApp() {
        Application.Quit();
    }
}

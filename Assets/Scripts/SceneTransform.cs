using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransform : MonoBehaviour
{
    public string GoToScene;

    public void DelayStartGame()
    {
        Invoke("StartGame", 0.8f);
    }

    public void DelayQuitGame()
    {
        Invoke("QuitGame", 0.8f);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(GoToScene);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    public void sceneTransform(string SceneTransform)
    {
        GoToScene = SceneTransform;
    }
}

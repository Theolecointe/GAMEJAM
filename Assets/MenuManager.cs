using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("DEMO city");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
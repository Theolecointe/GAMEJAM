using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("DEMO city"); // Remplacez "GameScene" par le nom de votre sc�ne de jeu
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;          

/// <summary>
/// Script de l'�cran titre
/// </summary>
public class MenuScript : MonoBehaviour
{
    void OnGUI()
    {
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        // Affiche un bouton pour d�marrer la partie
        if (
          GUI.Button(
            // Centr� en x, 2/3 en y
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Start!"
          )
        )
        {
            // Sur le clic, on d�marre le premier niveau
            // "Stage1" est le nom de la premi�re sc�ne que nous avons cr��s.
            Application.LoadLevel("Stage1");
        }
    }
}

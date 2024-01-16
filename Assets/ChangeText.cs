using UnityEngine;
using UnityEngine.UI;  // Pour l'élément Text standard
// using TMPro; // Décommentez ceci si vous utilisez TextMeshPro

public class TextChanger : MonoBehaviour
{
    public Text myText; // Référence à l'élément Text. Changez en TMP_Text pour TextMeshPro

    public void ChangeText(string newText)
    {
        myText.text = newText;
    }
}
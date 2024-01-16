using UnityEngine;
using UnityEngine.UI;  // Pour l'�l�ment Text standard
// using TMPro; // D�commentez ceci si vous utilisez TextMeshPro

public class TextChanger : MonoBehaviour
{
    public Text myText; // R�f�rence � l'�l�ment Text. Changez en TMP_Text pour TextMeshPro

    public void ChangeText(string newText)
    {
        myText.text = newText;
    }
}
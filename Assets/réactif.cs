using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    public Text textComponent; 

    void Start()
    {
       
        textComponent.text = "le livreur porte le colis";
    }
}

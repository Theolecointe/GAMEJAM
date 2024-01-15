using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class switchView : MonoBehaviour
{

    [SerializeField] GameObject objectToToggle; // L'objet à activer/désactiver
    private KeyCode toggleKey = KeyCode.T;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current[Key.T].isPressed)
        {
            this.gameObject.SetActive(false);
            objectToToggle.SetActive(true);
        }
    }
}

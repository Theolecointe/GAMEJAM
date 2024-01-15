using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal.Internal;

public class switchView : MonoBehaviour
{

    [SerializeField] GameObject objectToToggle; // L'objet à activer/désactiver
    private KeyCode toggleKey = KeyCode.T;
    // Start is called before the first frame update
    Vector3 targetPosition; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = transform.position;

        if (Keyboard.current[Key.T].isPressed)
        {
            objectToToggle.transform.position = targetPosition;

            this.gameObject.SetActive(false);
            objectToToggle.SetActive(true);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal.Internal;

public class switchView : MonoBehaviour
{

    [SerializeField] GameObject fps; // L'objet à activer/désactiver
    [SerializeField] GameObject tps;
    [SerializeField] GameObject velo;
    [SerializeField] GameObject playerCapsuleTps;
    [SerializeField] GameObject capsuleFps;
    [SerializeField] GameObject capsuleTps;

    Vector3 transformSponFps;  
    
    // Start is called before the first frame update
    Vector3 targetPosition; 

    void Start()
    {
        
    }

    void mount()
    { 
        fps.SetActive(false);
        tps.SetActive(true);
        velo.transform.SetParent(playerCapsuleTps.transform); 
    }



    void unmount()
    {
        tps.SetActive(false);
        fps.SetActive(true);
        velo.transform.SetParent(null); 

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = transform.position;

        if (Keyboard.current[Key.E].isPressed)
        {
            if (gameObject.name == "TPS")
            {
                transformSponFps = capsuleTps.transform.position;
                unmount();
                capsuleFps.transform.position = transformSponFps;
            }
            else
            {
                mount(); 
            }
            


        }




    }
}

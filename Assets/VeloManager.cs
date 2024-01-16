using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal.Internal;

public class Velo : MonoBehaviour
{

    [SerializeField] GameObject fps; // L'objet à activer/désactiver
    [SerializeField] GameObject tps;
    [SerializeField] GameObject velo;
    [SerializeField] GameObject playerCapsuleTps;
    [SerializeField] GameObject capsuleFps;
    [SerializeField] GameObject capsuleTps;

    [SerializeField] GameObject cameraRoot;

    Vector3 transformSponFps;

    // Start is called before the first frame update
    Vector3 targetPosition;


    private Rigidbody veloRigidbody;

    void Start()
    {

    }

    bool checkmount()
    {

        float distance = Vector3.Distance(velo.transform.position, capsuleFps.transform.position);
        
        if (distance < 1.600f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool checkUnmount()
    {
        ThirdPersonController tpc = capsuleTps.GetComponent<ThirdPersonController>(); 

        float veloVelocity = tpc._speed;

        

        if (veloVelocity == 0.0f)
        {
            return true;
        }

        else
        {
            return false;
        }


    }

    void mount()
    {
        if (checkmount())
        {
            fps.SetActive(false);
            tps.SetActive(true);
            velo.transform.SetParent(playerCapsuleTps.transform);
        }
       

    }



    void unmount()
    {

        
            tps.SetActive(false);
            fps.SetActive(true);
            velo.transform.SetParent(null);


    }

    void speedCheck()
    {

        ThirdPersonController tpc = capsuleTps.GetComponent<ThirdPersonController>();

        float veloVelocity = tpc._speed;

        //Debug.Log(veloVelocity);


    }




    // Update is called once per frame
    void Update()
    {

        speedCheck(); 

        if (Keyboard.current[Key.E].wasPressedThisFrame)
        {
            if (tps.active && checkUnmount()) 
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
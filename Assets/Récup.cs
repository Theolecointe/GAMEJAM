using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Récup : MonoBehaviour
{
    [SerializeField] int nombreRandom;
    [SerializeField] GameObject colis1;
    [SerializeField] GameObject colis2;
    [SerializeField] GameObject veloPivot;

    bool contactDump;
    bool contactLoad; 
    bool unColis = false;

    bool depose = false; 

    Vector3 adjust = new Vector3(0f, 1f, -1f);

    void OnTriggerEnter(Collider collider)
    {
        string currentTag = gameObject.tag;

        Livreur livreur = collider.GetComponent<Livreur>();
        unColis = livreur.CheckIfHoldingItem();
        

        if (currentTag == "dump")
        {
            contactDump = true;

            if (unColis)
            {
                Debug.Log("Vous avez livré le colis du client !");
                livreur.Drop();
                contactDump = true;
                depose = false;

            }
        }
        
        else if (currentTag == "Load")
        {
            contactDump = true;

            if(!unColis) 
            Debug.Log("Vous avez récupéré le colis du client !");
            livreur.PickUp();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        contactDump = false;
        contactLoad = false; 
    }


    // Start is called before the first frame update
    void Start()
    {



    }

    private void Update()
    {
         if (Keyboard.current[Key.F].wasPressedThisFrame)
         {
             if (!unColis && contactLoad)
             {
                 Debug.Log("On charge");
                 colis1.transform.SetParent(veloPivot.transform);
                 colis1.transform.localPosition = Vector3.zero;
                 colis1.transform.localRotation = Quaternion.identity;
                 depose = true;




            }

         }

        if (unColis && contactDump)
        {
            Debug.Log("On décharge");
            colis1.transform.SetParent(null);
            colis1.transform.position = transform.position;

        }
    }
}
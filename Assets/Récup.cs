using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Récup : MonoBehaviour
{
    [SerializeField] int nombreRandom;
    [SerializeField] private bool isLivraison;
    [SerializeField] GameObject colis1;
    [SerializeField] GameObject colis2;
    [SerializeField] GameObject veloPivot;
    [SerializeField]  

    bool contact;
    bool unColis = false; 

    Vector3 adjust = new Vector3 (0f, 1f, -1f);



    void OnTriggerEnter(Collider collider)
    {
        Livreur livreur = collider.GetComponent<Livreur>();
        unColis = livreur.CheckIfHoldingItem();
        contact = true; 

        if (isLivraison == true && unColis == true)
        {
            Debug.Log("Vous avez livré le colis du client !");
            livreur.Drop();

        }
        else if(isLivraison == false && unColis == false)
        {
            Debug.Log("Vous avez récupéré le colis du client !");
            livreur.PickUp();

    
        }

      
    }

    private void OnTriggerExit(Collider other)
    {
        contact = false;
    }


    // Start is called before the first frame update
    void Start()
    {


        
    }

    private void Update()
    {
        if (Keyboard.current[Key.F].wasPressedThisFrame)
        {
            if (contact && !unColis)
            {
                Debug.Log("On charge");
                colis1.transform.SetParent(veloPivot.transform);
                colis1.transform.localPosition = Vector3.zero;
                colis1.transform.localRotation = Quaternion.identity; 
                

            }

        }

        if(contact && unColis)
        {
            Debug.Log("On décharge");
            colis1.transform.SetParent(null);
            colis1.transform.position = transform.position; 

        }
    }
}
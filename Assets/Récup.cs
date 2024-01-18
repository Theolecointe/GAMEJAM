using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Récup : MonoBehaviour
{
    
    [SerializeField] public bool isLivraison;

    [SerializeField] GameObject depot;
    [SerializeField] GameObject recup; 
    bool contact;
    Livreur livreur;
  
    void OnTriggerEnter(Collider collider)
    {
        livreur = collider.GetComponent<Livreur>();
        bool unColis = livreur.CheckIfHoldingItem();
        contact = true;

        if (isLivraison == true && unColis == true)
        {
            Debug.Log("Vous avez livré le colis du client !");
            livreur.Drop();
            if(recup.activeSelf)
            {
                livreur.GetComponentInChildren<directionnalArrow>().objectif = recup;
            }
            else
            {
                gameObject.SetActive(false);
                transform.parent.parent.GetComponent<ObjectifsManager>().NextPaire();
            }
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        contact = false;
        livreur = null;
    }

    private void Update()
    {
        if (livreur == null)
            return;

        ThirdPersonController tpc = livreur.GetComponent<ThirdPersonController>();
        float veloVelocity = tpc._speed;
        if (isLivraison == false && livreur?.CheckIfHoldingItem() == false && contact && Keyboard.current[Key.F].wasPressedThisFrame && veloVelocity <= 0.2f)
        {
            Debug.Log("Vous avez récupéré le colis du client !");
            livreur.PickUp(transform.childCount);
            Debug.Log("On charge");
            livreur.GetComponentInChildren<directionnalArrow>().objectif = depot;

            for (int i = 0; i < livreur.maxColis; i++)
            {
                if(i < transform.childCount)
                    Destroy(gameObject.transform.GetChild(i).gameObject);
            }
            
            livreur = null;

        }
    }
}
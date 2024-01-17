using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Récup : MonoBehaviour
{
    
    [SerializeField] private bool isLivraison;

    [SerializeField] directionnalArrow directionnalArrow;
    [SerializeField] GameObject depot;

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
        }

       
    }

    private void OnTriggerExit(Collider other)
    {
        contact = false;
        livreur = null;
    }

    private void Update()
    {
        ThirdPersonController tpc = livreur.GetComponent<ThirdPersonController>();

        float veloVelocity = tpc._speed;

        if (isLivraison == false && livreur?.CheckIfHoldingItem() == false && contact && Keyboard.current[Key.F].wasPressedThisFrame && veloVelocity <= 0.2f)
        {
            Debug.Log("Vous avez récupéré le colis du client !");
            livreur.PickUp();
            Debug.Log("On charge");
            livreur = null;


            directionnalArrow.objectif = depot;
            
        }

    }
}
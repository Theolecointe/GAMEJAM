using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Récup : MonoBehaviour
{
    [SerializeField] int nombreRandom;
    [SerializeField] private bool isLivraison;
    [SerializeField] private float montantAjoute = 10.0f; 
    public GestionArgent gestionArgent;
    public TextMeshProUGUI argentText;
    private bool dejaTouchee = false;

    void OnTriggerEnter(Collider collider)
    {
        Livreur livreur = collider.GetComponent<Livreur>();
        bool unColis = livreur.CheckIfHoldingItem();


        if (isLivraison == true && unColis == true)
        {
            Debug.Log("Vous avez livré le colis du client !");
            livreur.Drop();

            gestionArgent.AjouterArgent(montantAjoute);
            UpdateDebugText("Argent" + montantAjoute + "$");
            dejaTouchee = true;

        }
        else if(isLivraison == false && unColis == false)
        {
            Debug.Log("Vous avez récupéré le colis du client !");
            livreur.PickUp();
        }


      
    }

    private void UpdateDebugText(string v)
    {
        throw new NotImplementedException();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


}

public class GestionArgent
{
    internal void AjouterArgent(float v)
    {
        throw new NotImplementedException();
    }
}


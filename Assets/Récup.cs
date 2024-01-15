using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Récup : MonoBehaviour
{
    [SerializeField] int nombreRandom;
    [SerializeField] private bool isLivraison;
    void OnTriggerEnter(Collider collider)
    {
        Livreur livreur = collider.GetComponent<Livreur>();
        bool unColis = livreur.CheckIfHoldingItem();


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

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
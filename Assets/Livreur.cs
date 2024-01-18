using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Livreur : MonoBehaviour

{
    private bool isHoldingItem = false;
    [SerializeField] GameObject colis;
    [SerializeField] GameObject colis1;
    [SerializeField] GameObject colis2;

    

    public int maxColis = 1;
    HUD hud;
    private void Start()
    {
        hud = FindObjectOfType<HUD>();
    }
    public bool CheckIfHoldingItem()
    {
        if (isHoldingItem)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

  

    internal void Drop()
    {
        int montantAjoute = 50; 
        hud.UpdateDebugText("Le livreur ne porte pas le colis.");
        hud.AddMoney(montantAjoute);
        colis.SetActive(false);
        colis1.SetActive(false);
        colis2.SetActive(false);   
        isHoldingItem = false;
    }

    internal void PickUp(int nb)
    {
           
        colis.SetActive(true);
        if( maxColis == 2 && nb > 1)
        {
            colis1.SetActive(true);
        }
        else if(maxColis == 3 && nb > 2)
        {
            colis2.SetActive(true);
        }

        hud.UpdateDebugText("Le livreur porte le colis.");
        isHoldingItem = true;
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Livreur : MonoBehaviour

{
    private bool isHoldingItem = false;
    private int montantDArgent;
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
        int montantAjoute = 100; 
        montantDArgent += montantAjoute;

        hud.UpdateDebugText("Le livreur ne porte pas le colis.");
        hud.UpdateMoney(montantDArgent);
        colis.SetActive(false);
        colis1.SetActive(false);
        colis2.SetActive(false);   
        isHoldingItem = false;
    }

    internal void PickUp()
    {
        colis.SetActive(true);
        if( maxColis == 2)
        {
            colis1.SetActive(true);
        }
        else if(maxColis == 3)
        {
            colis2.SetActive(true);
        }

        hud.UpdateDebugText("Le livreur porte le colis.");
        isHoldingItem = true;
    }


}

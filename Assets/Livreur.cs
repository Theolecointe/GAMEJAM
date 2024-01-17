using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Livreur : MonoBehaviour

{
    private bool isHoldingItem = false;
    private int montantDArgent;
    [SerializeField] GameObject colis;
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
        isHoldingItem = false;
    }

    internal void PickUp()
    {
        colis.SetActive(true);
        hud.UpdateDebugText("Le livreur porte le colis.");
        isHoldingItem = true;
    }


}

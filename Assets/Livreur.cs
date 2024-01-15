using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Livreur : MonoBehaviour
{
    private bool isHoldingItem = false;
  
    public bool CheckIfHoldingItem()
    {
        if (isHoldingItem)
        {
            Debug.Log("Le joueur porte le Colis.");
            return true;

        }
        else
        {
            Debug.Log("Le joueur ne porte pas le Colis.");
            return false;
        }
    }

    internal void Drop()
    {
        isHoldingItem = false;
    }

    internal void PickUp()
    {
        isHoldingItem = true;
    }

}

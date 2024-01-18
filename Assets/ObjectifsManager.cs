using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectifsManager : MonoBehaviour
{
    int currentPaire = 0;
    public void NextPaire()
    {
        transform.GetChild(currentPaire).gameObject.SetActive(false);
        currentPaire++;
        if(currentPaire < transform.childCount)
        {
            var newPaire = transform.GetChild(currentPaire);
            newPaire.gameObject.SetActive(true);
            var allPlaques = newPaire.GetComponentsInChildren<Récup>();
            foreach(var p in allPlaques)
            {
                if(!p.isLivraison)
                {
                    FindObjectOfType<directionnalArrow>().objectif = p.gameObject;
                }
            }
        }
        else
        {
            //LE JOUEUR A FINI TOUS LES OBJECTIFS
        }
    }
}

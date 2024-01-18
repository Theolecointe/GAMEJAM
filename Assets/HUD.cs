using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class HUD : MonoBehaviour
{
    [SerializeField] TMP_Text argentText;
    [SerializeField] TMP_Text debugText;

    private int _montantDArgent;

    private void Start()
    {
        MontantDArgent = 0;
    }
    int MontantDArgent
    {
        get
        {
            return _montantDArgent;
        }
        set
        {
            _montantDArgent = value;
            UpdateMoney();
        }
    }

    [SerializeField] ShopManager shopManager;

    public void TryBuyItem(ShopItem item)
    {
        if (MontantDArgent >= item.cost)
        {
            shopManager.RemoveItem(item);
            MontantDArgent -= item.cost;
            FindObjectOfType<Livreur>().maxColis++;
        }
    }
    private void UpdateMoney()
    {
        if (argentText != null)
        {
            argentText.text = MontantDArgent + "$";
        }
        shopManager?.UpdateCanBuy(MontantDArgent);
    }
    public void UpdateDebugText(string message)
    {
        if (debugText != null)
        {
            debugText.text = message;
        }
    }

    public void AddMoney(int montantAjoute)
    {
        MontantDArgent += montantAjoute;
    }

    private void Update()
    {
        if (Keyboard.current[Key.P].wasPressedThisFrame)
        {
            shopManager.ToggleShop();
        }
    }
}


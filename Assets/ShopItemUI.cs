using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UI;

public class ShopItemUI : MonoBehaviour
{
    [SerializeField] public ShopItem item;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text priceText;
    [SerializeField] Button button;
    Action<ShopItem> clickCallback;
    public void Init(ShopItem _item, Action<ShopItem> _clickCallback)
    {
        clickCallback = _clickCallback;
        item = _item;
        nameText.text = item.itemName;
        priceText.text = item.cost + "$";
    }

    public void Click()
    {
        clickCallback?.Invoke(item);
    }

    public void SetCanBuy(bool canBuy)
    {
        button.interactable = canBuy;
    }
}

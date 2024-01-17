using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class ShopItem
{
    public string itemName;
    public int cost;
}
public class ShopManager : MonoBehaviour
{
    public GameObject shopPanel; 
    public List<ShopItem> itemsForSale;

    [SerializeField] ShopItemUI shopItemUIPrefab;
    [SerializeField] Transform shopItemUIHolder;

    List<ShopItemUI> allUI = new List<ShopItemUI>();
    private void Awake()
    {
        InstantiateItems();
    }

    void InstantiateItems()
    {
        for(int i = shopItemUIHolder.childCount - 1; i >= 0; i--)
        {
            Destroy(shopItemUIHolder.GetChild(i).gameObject);
        }

        allUI = new List<ShopItemUI>();

        foreach (var s in itemsForSale)
        {
            var i = Instantiate(shopItemUIPrefab, shopItemUIHolder);
            allUI.Add(i);
            i.Init(s, (x)=>
            {
                FindObjectOfType<HUD>().TryBuyItem(x);
            });
        }
    }

    public void UpdateCanBuy(int currentMoney)
    {
        foreach(var siu in allUI)
        {
            siu.SetCanBuy(currentMoney >= siu.item.cost);
        }

    }

    public void RemoveItem(ShopItem shopItem)
    {
        if(itemsForSale.Contains(shopItem))
           itemsForSale.Remove(shopItem);

        InstantiateItems();
    }

    public void ToggleShop()
    {
        bool active = !shopPanel.activeSelf;
        shopPanel.SetActive(active);
        Cursor.visible = active;
        Cursor.lockState = active ? CursorLockMode.None : CursorLockMode.Locked;

    }

   
}
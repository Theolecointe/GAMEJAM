using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterShop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ShopManager shop;

    private void OnTriggerEnter(Collider collider)
    {
     
      shop.ToggleShop(); 
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

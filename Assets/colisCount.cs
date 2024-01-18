using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisCount : MonoBehaviour

{
    [SerializeField] GameObject prefabDelivery;
    // Start is called before the first frame update
    public int chargeMax = 1;

    void countColis()
    {
        int numberOfChildren = transform.childCount;

        if (numberOfChildren == 0)
        {
            gameObject.SetActive(false); 
        }

    }


    // Update is called once per frame
    void Update()
    {
        countColis(); 
        
    }
}

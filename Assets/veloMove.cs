using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class veloMove : MonoBehaviour
{

    [SerializeField]float accelerateSpeed = 10f;
    [SerializeField] float forceFrein = 5f;
    [SerializeField] float decelerateForce = 0.2f;


    private StarterAssetsInputs _input;

    private ThirdPersonController myScript;

    

    // Start is called before the first frame update
    void Start()
    {
        myScript = GetComponent<ThirdPersonController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current[Key.W].isPressed)
            myScript.SpeedChangeRate = accelerateSpeed; 
        else if (Keyboard.current[Key.E].isPressed)
            myScript.SpeedChangeRate = forceFrein;
        else
            myScript.SpeedChangeRate = decelerateForce;
    }


}

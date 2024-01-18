using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class VeloMove : MonoBehaviour
{

    [SerializeField] float accelerateSpeed = 10f;
    [SerializeField] float forceFrein = 5f;
    [SerializeField] float decelerateForce = 0.2f;
    [SerializeField] GameObject corp;


    private StarterAssetsInputs _input;

    private ThirdPersonController myScript;

    Quaternion angleRotation;

    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        myScript = GetComponent<ThirdPersonController>();
        //angleRotation = Quaternion.AngleAxis(10.35f, corp.transform.forward);

      
    }

    // Update is called once per frame
    void Update()
    {
        angleRotation = Quaternion.AngleAxis(10.35f, transform.forward);

        if (Keyboard.current[Key.W].isPressed)
            myScript.SpeedChangeRate = accelerateSpeed;
        else if (Keyboard.current[Key.S].isPressed)
            myScript.SpeedChangeRate = forceFrein;
        else
            myScript.SpeedChangeRate = decelerateForce;

       

    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionnalArrow : MonoBehaviour
{

    public GameObject objectif;
    Vector3 originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        // Enregistrer la rotation originale

        // Faire tourner l'objet vers la cible
        transform.LookAt(new Vector3(objectif.transform.position.x, objectif.transform.position.y, objectif.transform.position.z));

        // Rétablir les rotations X et Z d'origine
        transform.eulerAngles = new Vector3(originalRotation.x, transform.eulerAngles.y, originalRotation.z);


    }
}

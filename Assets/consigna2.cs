using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consigna2 : MonoBehaviour
{
    public string palabraClave;

    // Start is called before the first frame update
    void Start()
    {
        if (palabraClave == "domingo")
        {
            Debug.Log("Has adivinado la palabra");
        }
        else
        {
            Debug.Log("Palabra incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
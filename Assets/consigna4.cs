using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consigna4 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int dinero;
    int preciototal;
    // Start is called before the first frame update
    void Start()
    {
        preciototal = precio2 + precio1;
            if(preciototal == dinero)
        {
            Debug.Log("la cantidad de dinero alcanza para pagar los dos precios exactamente.");
        }
        else
        {
            Debug.Log("el precio es insuficiente o se exede ");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class con5 : MonoBehaviour
{
    public int Numero;
    int negativos;
    int dies;
    // Start is called before the first frame update
    void Start()
    {
       
        if (Numero < 0 && Numero > 10)
        {
            Debug.Log("el numero es negativo o mayor a 10 ");
        }
        else
        {
            Debug.Log("el numero cumple con las condiciones");

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

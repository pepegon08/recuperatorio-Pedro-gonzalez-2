using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consigna1 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 == numero2)
        {
            Debug.Log("los numeros son iguales");
        }
        if (numero1 < numero2)
        {
            Debug.Log("el mayor numero de los ingresadoes es " + numero2);
        }
        else {
            Debug.Log("el mayor numero de los ingresadoes es " + numero1);
        }
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

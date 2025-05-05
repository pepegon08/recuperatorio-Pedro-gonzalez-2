using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consigna3 : MonoBehaviour
{
    public float numero;
    public float Divisor;
    // Start is called before the first frame update
    void Start()
    {
        if (Divisor == 0)
        {
            return;
        }
        Debug.Log(numero / Divisor);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

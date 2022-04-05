using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej06 : MonoBehaviour
{
    public int num1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == 0)
        {
            Debug.Log("El valor tiene que ser mayor a 0");
        }
        else if ((num1 % 2) == 0) 
        {
            Debug.Log("El numero es par");
        }
        else
        {
            Debug.Log("El numero es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

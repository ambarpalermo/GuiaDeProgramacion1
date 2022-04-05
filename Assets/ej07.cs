using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej07 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num2 == num3) 
        {
            Debug.Log("Los numeros son iguales");
        }
        else if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El numero" + num1 + "es mayor");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El numero" + num2 + "es mayor");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Debug.Log("El numero" + num3 + "es mayor");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

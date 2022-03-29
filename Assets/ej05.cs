using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej05 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        int resultado = (num1 / num2);
        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por 0");
        }
        else
        {
            Debug.Log(num1 + "/" + num2 + " = " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

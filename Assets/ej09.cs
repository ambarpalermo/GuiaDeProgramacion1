using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej09 : MonoBehaviour
{
    public float nombre1;
    public float nombre2;
    public float nombre3;


    public float capital1;
    public float capital2;
    public float capital3;


    float capitalTotal;
    float porc1;
    float porc2;
    float porc3;

    // Start is called before the first frame update
    void Start()
    {
        capitalTotal = capital1 + capital2 + capital3;
        porc1 = capital1 / capitalTotal * 100;
        porc2 = capital2 / capitalTotal * 100;
        porc2 = capital3 / capitalTotal * 100;

        Debug.Log("Nombre: " + nombre1 + "el capital apotado: $ " + capital1 + ", Porcentaje del capital: % "
            + porc1 + ", monto total aportado: $ " + capitalTotal);
        Debug.Log("Nombre: " + nombre2 + "el capital apotado: $ " + capital2 + ", Porcentaje del capital: % "
            + porc2 + ", monto total aportado: $ " + capitalTotal);
        Debug.Log("Nombre: " + nombre3 + "el capital apotado: $ " + capital3 + ", Porcentaje del capital: % "
            + porc3 + ", monto total aportado: $ " + capitalTotal);
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}

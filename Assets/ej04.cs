using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej04 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        int suma = (num1 + num2);
        Debug.Log ("La suma ente " + num1 + "y " + num2 + " da como resultado " + suma + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculosmanager : MonoBehaviour
{
    public Vehiculo VehiculoScript;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cant ruedas: " + VehiculoScript.cantRuedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

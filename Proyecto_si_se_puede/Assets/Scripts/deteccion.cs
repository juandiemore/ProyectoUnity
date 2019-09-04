using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccion : MonoBehaviour
{
    private move movimiento;
    // Start is called before the first frame update
    void Awake()
    {
        movimiento = GetComponent<move>();
        GetComponent<Collider>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "npc"){
            print("chino hpta");
        }
    }
}

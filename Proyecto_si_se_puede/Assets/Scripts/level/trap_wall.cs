using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_wall : MonoBehaviour
{
    Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
   private void OnTriggerExit(Collider other) {
       if(other.name == "aj"){
        posicion = transform.position;
        posicion.y -=.7f;
        transform.position = posicion;
       }
   }
}

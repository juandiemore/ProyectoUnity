using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisson : MonoBehaviour
{
    float pois;
    // Start is called before the first frame update
    void Start()
    {
        pois = .8f;
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other) {
        if(other.name == "aj"){
            other.GetComponent<vida_aj>().TakeDamage(pois);
            other.GetComponent<AjControl>().dolor();
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(transform.up*35f);
            rb.AddForce(transform.forward*-5f);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
  private float x;
    private float z;
    private bool rotateX;
    private float rotationSpeed;

 //   GameObject power;
    void Awake(){
   // power = GetComponent<GameObject>();
    }
    void Start()
    {
        x = 0.0f;
        z = 0.0f;
        rotateX = true;
        rotationSpeed = 75.0f;
    }

    void FixedUpdate()
    {
        
            x += Time.deltaTime * rotationSpeed;

        

        transform.localRotation = Quaternion.Euler(0, x, 0);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.name == "aj"){
            if(this.name == "PowerUp"){
            Vector3 enano = new Vector3(.5f,.5f,.5f);
            Vector3 normal = new Vector3(1,1,1);
            if(other.transform.lossyScale != enano){
            this.transform.gameObject.SetActive(false);
            other.transform.localScale = enano;
            }else {
                other.transform.localScale = normal;
                this.transform.gameObject.SetActive(false);
            }

        }
        else if(this.name == "Speed"){
            move Smove =  other.GetComponent<move>();
            float actualSpeed = Smove.getSpeed();
            float extraSpeed = 5f;
             actualSpeed += extraSpeed;
            Smove.setSpeed(actualSpeed);
            this.transform.gameObject.SetActive(false);
            
        }
   
   }
}


}
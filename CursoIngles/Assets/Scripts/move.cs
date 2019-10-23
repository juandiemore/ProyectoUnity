using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movimiento;
     public float rotacion;
    public float speed = 10f;
    public float velocidadRotacion = 60f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotacion = Input.GetAxis("Horizontal")*velocidadRotacion;
        
        movimiento = Input.GetAxis("Vertical")*speed;
        movimiento *= Time.deltaTime;
        rotacion *= Time.deltaTime;
        transform.Translate(0,0,movimiento);
        transform.Rotate(0,rotacion,0);
    }
    public float getSpeed(){
        return speed;
    }
    public void setSpeed(float s){
        this.speed = s;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida_aj : MonoBehaviour
{
    // Start is called before the first frame update

    public float vidaInicial=100f;
    [SerializeField]
    float vida;
    public Image barra;
    
    void Start()
    {
       vida = vidaInicial;
    }

    // Update is called once per frame
    void Update(){
    barra.fillAmount = vida/vidaInicial;
    }
    public void TakeDamage(float damage){

       
        vida -=damage;
        if(vida <= 0){
            print("mueres");
        }
    }
    public void TakeHeal(float cura){
         if(vida <= vidaInicial){
             vida += cura;
        }
       
    }
}

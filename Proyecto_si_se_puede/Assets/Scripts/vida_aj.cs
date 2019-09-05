using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida_aj : MonoBehaviour
{
    // Start is called before the first frame update

    public float vida=100f;
    public Image barra;
    
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        barra.fillAmount = vida;
        
        
    }
}

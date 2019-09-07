using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brainCounter : MonoBehaviour
{
 [SerializeField] Text puntos;
    int score = 1;
    // Start is called before the first frame update
    void Start()
    {
       puntos.text = "X0";
    }

    // Update is called once per frame
    public void addBrain()
    {
        puntos.text = "X"+score;
        score+=1;

    }
}

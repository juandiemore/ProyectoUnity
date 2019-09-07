using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainCounter : MonoBehaviour
{
   [SerializeField] public Text puntos;
    int score;
    // Start is called before the first frame update
    void Start()
    {
       puntos = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        puntos = "X"+score;
        score+=1;
    }
}

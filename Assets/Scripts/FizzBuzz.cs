using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FizzBuzz : IGenerable
{
    public TextMeshProUGUI fizz_buzz_display;


    
    // Start is called before the first frame update
    //void Start()
    //{
    //    RNG.Instance.RandomNumber();
    //    Debug.Log(RNG.number);
    //}
    public void RandomNumber(int number)
    {
        Debug.Log("FizzBuzz was called");
        Debug.Log(number);
    }
}

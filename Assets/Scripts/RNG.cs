using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RNG : IGenerable
{
    public static int number;



    public void RandomNumber()
    {
        number = Random.Range(1, 100);

        Debug.Log(number);

    }
}

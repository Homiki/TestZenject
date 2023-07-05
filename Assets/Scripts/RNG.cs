using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNG : IGenerable
{
    //public static int number;

    public void RandomNumber(int number)
    {
        number = Random.Range(1, 100);

        Debug.Log(number);
    }
}

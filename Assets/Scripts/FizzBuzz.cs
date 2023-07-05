using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Zenject;

public class FizzBuzz : IFizzBuzz
{
    public TextMeshProUGUI fizz_buzz_display;

    public List<int> display_list;

    //Start is called before the first frame update
    void Start()
    {
        Debug.Log(RNG.number);
    }
    private IGenerable generator;

    [Inject]
    public void Setup(IGenerable generator)
    {
        this.generator = generator;
    }
    public void AddToList()
    {
        Debug.Log("FizzBuzz was called");
        Debug.Log(RNG.number);

        //generator.RandomNumber();
        display_list = new List<int>();

        for (int i = 1; i <= RNG.number; i++)
        {
            display_list.Add(i);
        }
        FizzBuzzGenerator(display_list, fizz_buzz_display);
    }

    public string FizzBuzzGenerator(List<int> display_list, TextMeshProUGUI fizz_buzz_display)
    {
        Debug.Log("FizzBuzzCalled");
        foreach (var number in display_list)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                fizz_buzz_display.text += "FizzBuzz" + ", ";
            }
            if (number % 5 == 0)
            {
                fizz_buzz_display.text += "Buzz" + ", ";
            }
            if (number % 3 == 0)
            {
                fizz_buzz_display.text += "Fizz" + ", ";
            }
            else
            {
                fizz_buzz_display.text += number + ", ";
            }
        }

        return fizz_buzz_display.text;

    }
}

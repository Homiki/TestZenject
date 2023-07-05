using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using TMPro;

public class TestDependecyInjection : MonoBehaviour
{
    private IGenerable generator;
    private IFizzBuzz fizzbuzz;

    public TextMeshProUGUI fizz_buzz_display;
    public List<int> display_list;

    public int num;

    [Inject]
    public void Setup(IGenerable generator, IFizzBuzz fizzbuzz)
    {
        this.generator = generator;
        this.fizzbuzz = fizzbuzz;
    }



    // Start is called before the first frame update
    void Start()
    {
        generator.RandomNumber();
        fizzbuzz.AddToList();
        //fizzbuzz.FizzBuzzGenerator(display_list, fizz_buzz_display);
    }
}

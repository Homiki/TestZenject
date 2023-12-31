using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[Serializable]
public class FizzBuzzService
{
    private readonly IRandomNumber _generator;
    private readonly FizzBuzzView _fizzBuzzView;
    private List<int> displayList;

    public FizzBuzzService(FizzBuzzView fizzBuzzView, IRandomNumber generator)
    {
        _generator = generator;
        _fizzBuzzView = fizzBuzzView;
        Debug.Log("Started");
        StartFizzBuzz();
    }

    private void StartFizzBuzz()
    {
        // 1. Pobieramy liczbę z Generatora;
        var number = _generator.GenerateNumber();

        // 2. generujesz liczbę liczb ktorą wylosowales
        // number for (number razy) GenerateNumber();
        // tablica/hashset/lista
        AddToList();

        //3. Przejść po wszystkich elementach i sprawdź fizzbuzz;
        // string ValidFizzBuzz(number[i]) 
        
        //4. FizzBuzzView -> wypisz wszystkie elementy String.Concat 
    }
    
    public void AddToList()
    {
        //displayList.Clear();

        //Debug.Log(RandomNumberService.number);

        ////generator.RandomNumber();
        //displayList = new List<int>();

        //for (int i = 1; i <= RandomNumberService._number; i++)
        //{
        //    displayList.Add(i);
        //}
        //FizzBuzzGenerator(displayList, _fizzBuzzView);

            displayList.Clear();

            Debug.Log(_generator.GenerateNumber());

            //generator.RandomNumber();
            displayList = new List<int>();

            for (int i = 1; i <= _generator.GenerateNumber(); i++)
            {
                displayList.Add(i);
            }

            FizzBuzzGenerator(displayList, _fizzBuzzView.FizzBuzzText);
        }

    public string FizzBuzzGenerator(List<int> displayList, TextMeshProUGUI fizzBuzzDisplay)
    {
        foreach (var number in displayList)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                fizzBuzzDisplay.text += "FizzBuzz" + ", ";
            }
            if (number % 5 == 0)
            {
                fizzBuzzDisplay.text += "Buzz" + ", ";
            }
            if (number % 3 == 0)
            {
                fizzBuzzDisplay.text += "Fizz" + ", ";
            }
            else
            {
                fizzBuzzDisplay.text += number + ", ";
            }
        }

        return fizzBuzzDisplay.text;
    }
}

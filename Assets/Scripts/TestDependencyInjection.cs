using System.Collections.Generic;
using UnityEngine;
using Zenject;
using TMPro;

public class TestDependencyInjection : MonoBehaviour
{
    private IRandomNumber _generator;
    private IFizzBuzz _fizzbuzz;

    public TextMeshProUGUI fizzBuzzDisplay;
    public List<int> displayList;

    public int num;

    [Inject]
    public void Setup(IRandomNumber generator, IFizzBuzz fizzbuzz)
    {
       _generator = generator;
       _fizzbuzz = fizzbuzz;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _generator.GenerateNumber();
        _fizzbuzz.AddToList();
    }
}

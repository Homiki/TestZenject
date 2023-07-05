using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TestDependecyInjection : MonoBehaviour
{
    private IGenerable generator;

    [Inject]
    public void Setup(IGenerable generator)
    {
        this.generator = generator;
    }



    // Start is called before the first frame update
    void Start()
    {
        generator.RandomNumber(Random.Range(1, 100));
    }

}

using UnityEngine;

public class RandomNumberService : IRandomNumber
{
    private int _number;
    public int GenerateNumber()
    {
        return Random.Range(1, 100);
    }
}

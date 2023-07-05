using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public interface IFizzBuzz
{
    public void AddToList();
    public string FizzBuzzGenerator(List<int> display_list, TextMeshProUGUI fizz_buzz_display);
}

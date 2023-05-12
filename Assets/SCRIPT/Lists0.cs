using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists0 : MonoBehaviour
{

    List<int> numbers = new List<int>();

    void Start()
    {

        numbers.Add(10);
        numbers.Add(7094);
        numbers.Add(1000);
        numbers.Add(1);
        numbers.Add(5343);
        numbers.Add(30);
        numbers.RemoveAt(3);
        numbers.Sort();
        numbers.RemoveRange(0, 2);
        numbers.IndexOf(2);

        int LCount = numbers.Count;

        foreach (int i in numbers)
        {
            print(i);

        }
    }

    
    void Update()
    {
        
    }
}

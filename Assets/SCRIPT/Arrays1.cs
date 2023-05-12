using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays1 : MonoBehaviour
{

    int[] numbers;

    void Start()
    {
        numbers = new int[50];

        
        for(int i = 0; i < numbers.Length; i++)
        {

            numbers[i] = (i + 1) * 10;
            print(numbers[i]);

        }
        

        foreach(int i in numbers)
        {

            print(i);

        }
    }

    
    void Update()
    {
        
    }
}

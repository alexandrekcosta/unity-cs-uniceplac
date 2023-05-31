using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : MonoBehaviour
{

    int RandomNumber;

    void Start()
    {
        StartPoint:
        RandomNumber = Random.Range(0, 11);

        if(RandomNumber <= 5)
        {

            print(RandomNumber);
            goto StartPoint;

        }
        else
        {

            print(RandomNumber);
            print("Random number is bellow 5");

        }

    }

    
    void Update()
    {
        
    }
}

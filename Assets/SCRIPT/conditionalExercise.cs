using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class conditionalExercise : MonoBehaviour
{

    int n1 = 10;
    int n2 = 5;
    
    void Start()
    {
        if(n1 > n2)
        {

            print(n1+" is higher than "+n2);

        }
        else if(n2 > n1)
        {

            print(n2+" is higher than "+n1);

        }
        else
        {

            print("Both numbers equal each other");

        }
    }

    
    void Update()
    {
        
    }
}

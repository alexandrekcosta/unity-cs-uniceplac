using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For0 : MonoBehaviour
{
    

    void Start()
    {
        for (int i = 1; i < 10; i++)
        {

            if (i == 5)
            {

                break;

            }

            print(i);
        }
    }

    
    void Update()
    {
        
    }
}

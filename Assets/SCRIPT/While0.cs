using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While0 : MonoBehaviour
{

    int x = 0;

    void Start()
    {

        while (x < 10)
        {

            print(x);
            x = x + 1;

        }

    }

    
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile0 : MonoBehaviour
{

    int x = 0;

    void Start()
    {
        do
        {

            print(x);
            x = x + 1;

        } while (x < 10);

    }

    
    void Update()
    {
        
    }
}

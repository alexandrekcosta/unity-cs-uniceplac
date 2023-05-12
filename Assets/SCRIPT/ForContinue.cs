using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForContinue : MonoBehaviour
{
    
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {

            if(i == 5)
            {

                continue;

            }

            print(i);

        }   
    }

    
    void Update()
    {
        
    }
}

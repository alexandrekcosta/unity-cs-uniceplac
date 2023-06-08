using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputClass : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {

        if (input.GetKeyDown(KeyCode.Space))
        {

            print("Spacebar has been pressed");

        }

    }
}

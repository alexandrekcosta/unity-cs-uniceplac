using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowClass : MonoBehaviour
{
    
    public int n1;

    private void Start()
    {

        if (n1 < 0)
        {

            throw new System.Exception("This is a negative number");

        }

    }

   
}


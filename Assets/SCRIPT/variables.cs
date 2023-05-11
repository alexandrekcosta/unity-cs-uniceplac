using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;


public class variables : MonoBehaviour
{
    int n1, n2,subResult;
    
    void Start()
    {

        n1 = 10;
        n2 = 20;
        Sum();
        multiplication(n1,n2);
        subResult = sub(n1, n2);
        print(subResult);

    }

 
    void Update()
    {


    }

    void Sum()
    {

        int result;
        result = n1 + n2;
        print(result);

    }

    void multiplication(int v1,int v2)
    {
        int result;
        result = v1 * v2;
        print(result);


    }

    int sub(int v1,int v2)
    {

        int result;
        result = v1 - v2;
        return result;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesClass : MonoBehaviour
{

    Example obj = new Example();
    private int x;

    void Start()
    {

        x = obj.p;
        obj.p = 20;

    }

    
    void Update()
    {
        
    }
}

public class Example
{

    private int n = 10;
    public int p
    {
        get { return n; }
        set { n = value; }

    }
}

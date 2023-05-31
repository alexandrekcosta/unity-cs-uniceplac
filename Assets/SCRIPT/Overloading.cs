using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overloading : MonoBehaviour
{

    Calc calc = new Calc();
    

    
    void Start()
    {

        resultInt = calc.sum(5,2);
        resultFloat = calc.sum(3.5f + 5.5f);
        resultMultiple = calc.sum(2, 3, 4);
        Destroy(this.gameObject, 2);
        
    }

    void Update()
    {
        
    }

  
}

public class Calc(){

    public int sum(int a,int b)
    {

        return a + b;

    }

    public float sum(float a,float b)
    {

        return a + b;

    }

    public int sum(int a,int b,int c)
    {

        return a + b + c;

    }

}

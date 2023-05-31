using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modificator : MonoBehaviour
{
  
    public int number;
    private int number2;
    protected float number3;

    number3 = 2.5f;

    public int passValue()
    {

        return number2;

    }

    public void modificator(int number)
    {

        this.number2 = number;

    }
    
}

public class test : Modificator
{

    void access()
    {

        number = 10;
        number = passValue();
        modificator(100);

    }

}

public class protect
{

    number3 = 10f;

}

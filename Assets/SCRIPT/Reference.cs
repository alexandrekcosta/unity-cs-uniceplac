using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    int number = 10;
    int sum;
    int subtraction;
    int SumArray;

    void Start()
    {

        example(ref number);
        sum = operations(20, 20 out subtraction);
        SumArray = NumbersSum(20,203,5,10);
    }

    void example(ref int n)
    {

        n = NumbersSum(50,30,100,200);
        print(n);

    }
    
    public int operations(int a,int b,out int sub)
    {

        sub = a - b;
        return a + b;

    }

    int NumbersSum(params int[] array)
    {

        int result = 0;

        for(int i; i < array.Length; i++)
        {

            result += array[i];

            return result;

        }

    }
}

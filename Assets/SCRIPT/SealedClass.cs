using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealedClass : MonoBehaviour
{

    A object1 = new A();

    
    void Start()
    {

        object1.velocity = 50;

    }

    
    void Update()
    {
        
    }
}

sealed class A
{

    public int velocity;

}

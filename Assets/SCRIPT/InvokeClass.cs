using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeClass : MonoBehaviour
{
    
    void Start()
    {

        invoke("Like", 2.5f);

    }

    
    void Like()
    {

        print("Subscribe and Like my Channel");

    }
}

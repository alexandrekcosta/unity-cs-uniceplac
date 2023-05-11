using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class variables0 : MonoBehaviour
{

    float time;
   
    void Start()
    {
        
    }

 
    void Update()
    {
        time = time + Time.deltaTime;
        print(time);
    }
}

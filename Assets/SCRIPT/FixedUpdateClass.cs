using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class FixedUpdateClass : MonoBehaviour
{

    private void fixedUpdate(){

        print("Fixed update: " + Time.fixedDeltaTime);
        
     }
    void Start()
    {
            
    }

    
    void Update()
    {

        print("Update: " + Time.deltaTime);

    }
}

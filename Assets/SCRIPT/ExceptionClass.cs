using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionClass : MonoBehaviour
{

    int result, n1, n2;
    
    void Start()
    {

        try
        {

            result = n1 / n2;

        }
        catch (UnityException x)
        {

            print("Exception: Division equals zero " + x);

        }
        finally {

            print("Compilation has been finished");        
        
        
        }
        
    }

    
    void Update()
    {
        
    }
}

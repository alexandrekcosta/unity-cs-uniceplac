using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class routines0 : MonoBehaviour
{
    
    void Start()
    {

        StartCoroutine(routine());
        
    }

    
    void Update()
    {
        
    }

    IEnumerator routine()
    {

        print("Loading...");
        yield return new WaitForSeconds(2);
        print("It went 2 seconds...");
        int a = 0;
        yield return new WaitForSeconds(3);
        a = 20;
        print(a);
        yield return null;


    }

}

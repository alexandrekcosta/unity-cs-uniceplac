using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays0 : MonoBehaviour
{

    int[] array = { 10, 20, 30 };
    string[] names;

    void Start()
    {
        print(array[0]);
        print(array[1]);
        print(array[2]);

        names = new string[5];
        names[0] = "Alexandre";
        print(names[0]);
        array[1] = 40;
        print(array[1]);
    }

    
    void Update()
    {
        
    }
}

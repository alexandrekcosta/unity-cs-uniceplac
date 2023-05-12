using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class conditionalExercise0 : MonoBehaviour
{
    int enemy = 3;

    void Start()
    {

        if(enemy == 1)
        {

            print("Enemy is attacking");

        }
        else if(enemy == 2)
        {

            print("Enemy is defending");

        }
        else
        {

            print("Enemy is running away");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

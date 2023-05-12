using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch0 : MonoBehaviour
{
    int startVar = 3;


    void Start()
    {

        switch (startVar)
        {

            case 1:

                print("Enemy is attacking");

                break;

            case 2:

                print("Enemy is defending");

                break;

            case 3:

                print("Enemy is running away");

                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

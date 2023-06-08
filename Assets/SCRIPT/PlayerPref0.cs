using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;

public class PlayerPref0 : MonoBehaviour
{

    int a;
    bool b;

    void Start()
    {

        PlayerPrefs.SetInt("",b == true ? 1:0);
        PlayerPrefs.GetInt("a") ! = 0;
        
    }

    
    void Update()
    {

        if (input.GetMouseButtonDown(0) == true)
        {

            a = 1;
            PlayerPrefs.SetInt("a", a);
            PlayerPrefs.Save();

        }
        else if(input.GetMouseButtonDown(1) == true) {

            a = 0;
            PlayerPrefs.SetInt("a", a);
            PlayerPrefs.Save();

        }

        
        
    }

    int SaveBool()
    {

        if(b == true)
        {

            a = 1;

        }
        else
        {

            a = 0;

        }

        return a;
    }
   
}

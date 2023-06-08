using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMouseClass : MonoBehaviour
{

    private bool ClickLeft, ClickRight,StopClickLeft,StopClickRight;
    
    void Start()
    {
        
    }

    
    void Update()
    {

        ClickLeft = input.GetMouseButton(0);
        ClickRight = input.GetMouseButton(1);
        StopClickLeft = input.GetMouseButtonUp(0);
        StopClickRight = input.GetMouseButtonUp(1);

        if(ClickLeft == true)
        {

            print("Left button has been clicked");

        }else if(ClickRight == true)
        {

            print("Right button has been clicked");

        }else if(StopClickLeft == true)
        {

            print("left button isn't being touched anymore");

        }else if(StopClickRight == true)
        {

            print("Right button isn't being touched anymore");

        }
        
    }
}

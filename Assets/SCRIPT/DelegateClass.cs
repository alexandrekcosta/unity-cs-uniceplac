using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateClass : MonoBehaviour
{

    delegate void DelExample(int n);
    DelExample varDel;

    void Start()
    {

        varDel = attack;
        varDel += jump;
        varDel += defence;
        varDel -= jump;
        varDel();
    }

    
    void Update()
    {
        
    }

    void attack(int x)
    {

        //

    }

    void jump(DelExample m)
    {



    }

    void defence()
    {



    }

}

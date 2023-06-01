using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structs : MonoBehaviour
{
    Moto culiacan = new Moto();

    void Start("Culiacan",1000)
    {

        culiacan.turnOn();

    }

    
    void Update()
    {

        culiacan.power = 1000;

    }
}

public struct Moto
{

    public string brand;
    public float power;

    public void turnOn()
    {

        //

    }

    public Moto(string brand,float power)
    {

        this.brand = brand;
        this.power = power;

    }

}

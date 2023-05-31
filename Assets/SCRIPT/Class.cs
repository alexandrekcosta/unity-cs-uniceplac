using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    Aliza nimmi = new Aliza(100,100);

    
    void Start()
    {

        nimmi.strenght = 100;
        nimmi.velocity = 100;
        Class0.sum(5,15);
        
    }

    
    void Update()
    {

        nimmi.attack();

    }
}

class Vampire:MonoBehaviour{

    public int strenght;
    public int velocity;

    public Vampire(int strenght,int velocity)
    {

        this.strenght = strenght;
        this.velocity = velocity;


    }
    
    public void attack()
    {

        print("");

    }

}

class Aliza : Vampire
{

    print("");
    attack();

    public Aliza(int strenght,int velocity)
    {

        this.strenght = strenght;
        this.velocity = velocity;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisBase : MonoBehaviour
{
    int velocity;

    public test(int velocity)
    {

        this.velocity = velocity;

    }
}

public class Enemy
{

    public int attack;

}

public class Maev : Enemy
{

    public Maev(int attack)
    {

        base.attack = attack;

    }

}

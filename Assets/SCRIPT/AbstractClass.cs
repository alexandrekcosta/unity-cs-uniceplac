using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractClass : MonoBehaviour
{ 



}

   

    public abstract class Enemies
    {

        public float strenght, life;

        public enemies()
        {
            strenght = 50;
            life = 100;
        }

    abstract public void attack();
    }

    public class Butcher : Enemies
    {

        public override void attack()
        {
            throw new System.NotImplementedException();

        }

    }
    




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Override : MonoBehaviour
{
   

}

public class Monsters
{

    public virtual void attack()
    {



    }

}

public class Maev : Monsters
{

    public override void attack()
    {
        base.attack();
    }

}



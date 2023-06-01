using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceClass : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}

public interface IInteractions<T>
{

    void interactions(float T);


}

public interface ICombat
{

    void attack();

}

public class Door : MonoBehaviour, IInteractions<float>,ICombat
{

    public void interactions(float game)
    {

        //

    }


    public void attack()
    {

        //

    }

}

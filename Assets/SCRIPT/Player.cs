using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private void Start()
    {

        Enemy.OnEnemyDied += Commemorate();

    }

    private void Commemorate()
    {

        print("I won!!!")

    }

}

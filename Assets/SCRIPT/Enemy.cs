using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public delegate void EnemyDeath();
    public static event EnemyDeath OnEnemyDied;
    public int EnemyLife = 10;

    void Start()
    {
        
    }

    
    void Update()
    {

        if(EnemyLine == 0)
        {

            if (OnEnemyDied != null)
            {

                OnEnemyDied();

            }

        }
        
    }
}

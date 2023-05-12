using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionals : MonoBehaviour
{

    int coins = 200;
    int itemPrice = 200;

    void Start()
    {
        
        if(coins > itemPrice)
        {

            print("You have enough money to buy this item");

        }else if(coins == itemPrice)
        {

            print("You have enough money to buy this item,but after purchasing you will have no coin anymore");

        }
        else
        {

            print("You don't have enough money to buy this item");

        }

    }

    
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relationship: MonoBehaviour
{
    
    int n1 = 10;
    int n2 = 20;
    string name1 = "Alexandre";
    string name2 = "alexandre";
    bool win = true;
    bool lose = false;
    string result;
    string mood;
    bool pizza = true;
    bool softDrink = false;
    

    void Start()
    {
        result = n2 > n1 ? "Yes:it is true" : "No,it is false";
        mood = (pizza == true) && (softDrink == true) ? "I am happy" : "I am sad";
        print(result);
        print(mood);
        print(n1 == n2);//false
        print(name1 == name2);//false
        print(n2 > n1);//true
        print(win == lose);//false
        
    } 

    
    void Update()
    {
        
    }
}

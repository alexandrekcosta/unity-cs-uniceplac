using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary0 : MonoBehaviour
{

    Dictionary<string, string> biblical = new Dictionary<string, string>();
    
    void Start()
    {
        biblical.Add("Saint Michael Archangel","Height:300 cm "+
            "Type:Archangel "+
            "Country:Israel "+
            "Language:Hebrew ");

        biblical.Add("Abraham","Height:165 cm "+
            "Type:Patriarch "+
            "Country:Iraq "+
            "Language:Hebrew and Iraqi Semitic Languages");

        biblical.Remove("Saint Michael Archangel");
        print(biblical["Abraham"]);

        int LLenght = biblical.Count;

        print(LLenght);
    }

    
    void Update()
    {
        
    }
}

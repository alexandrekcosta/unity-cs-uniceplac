using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour
{

    int cont;
    
    void Start()
    {

        cont = PlayerPrefs.GetInt("cont");
        cont = cont + 1;
        print(cont);
        PlayerPrefs.SetInt("cont", cont);
        PlayerPrefs.Save();

        print(PlayerPrefs.HasKey("cont"));
        PlayerPrefs.DeleteKey("cont");
        
    }

    
    void Update()
    {
        
    }
}

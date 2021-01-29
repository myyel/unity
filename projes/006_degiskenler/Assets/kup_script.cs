using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup_script : MonoBehaviour
{
    int sayi=5;
    float ondalikli = 43.21f;
    string yazi = "merhaba";

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sayi; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

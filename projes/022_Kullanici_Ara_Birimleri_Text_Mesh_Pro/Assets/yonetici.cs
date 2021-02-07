using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    int saniye = 10;
    void Start()
    {
        //Invoke("saniye_azalt", 3);
        InvokeRepeating("saniye_azalt", 0, 1);
    }

    public void saniye_azalt()
    {
        saniye -= 1;
        Debug.Log(saniye);
    }


    void Update()
    {
        /*Debug.Log(Time.time.ToString());
        Time.timeScale = 0;*/
    }
}

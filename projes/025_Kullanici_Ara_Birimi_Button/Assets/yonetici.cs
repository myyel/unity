using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    int saniye = 10;

    bool oyun_durdur = false;


    public void durdur_btn()
    {
        oyun_durdur = !oyun_durdur;
        if (oyun_durdur==true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void tekrar_oyna()
    {
        SceneManager.LoadScene("Scenes/sahne_2");
        Time.timeScale = 1;
    }

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

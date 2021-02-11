using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cizgi_script : MonoBehaviour
{

    LineRenderer cizgi;

    Transform kup_1;
    Transform kup_2;
    Transform kup_3;

    ParticleSystem alev;

    void Start()
    {
        cizgi = GetComponent<LineRenderer>();

        kup_1 = GameObject.Find("kup_1").transform;
        kup_2 = GameObject.Find("kup_2").transform;
        kup_3 = GameObject.Find("kup_3").transform;

        cizgi.SetPosition(0, kup_1.position);
        cizgi.SetPosition(1, kup_2.position);
        cizgi.SetPosition(2, kup_3.position);

        alev = GameObject.Find("alev").GetComponent<ParticleSystem>();

        Invoke("atesi_sonlandir", 3.0f);
    }

    public void atesi_sonlandir()
    {
        alev.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

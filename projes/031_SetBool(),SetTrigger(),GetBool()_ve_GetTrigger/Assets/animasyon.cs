using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyon : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Space))
        {
            bool deger = !anim.GetBool("diger_animasyon");
            anim.SetBool("diger_animasyon", deger);
        }
    }
}

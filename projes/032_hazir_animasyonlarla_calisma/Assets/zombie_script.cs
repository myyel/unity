using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_script : MonoBehaviour
{
    public Animator anim;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("yuru");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("hareketsiz");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("saldir");
        }
    }
}

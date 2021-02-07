using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin_script : MonoBehaviour
{
    public int skor = 0;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {
            float rnd = Random.Range(-14.80f, -3.25f);
            collision.gameObject.transform.position = new Vector3(6.91f, 8, rnd);
        }
    }
}

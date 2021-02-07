using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zemin_script : MonoBehaviour
{
    public int skor = 0;
    float can = 100.0f;
    float suanki_can = 100.0f;

    public Image can_bar;
    public GameObject panel;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {
            float rnd = Random.Range(-14.80f, -3.25f);
            collision.gameObject.transform.position = new Vector3(6.91f, 8, rnd);
            suanki_can -= 10.0f;
            can_bar.fillAmount = suanki_can / can;

            if (suanki_can<0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}

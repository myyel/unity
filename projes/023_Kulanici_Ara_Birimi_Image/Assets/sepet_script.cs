using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepet_script : MonoBehaviour
{

    public float hiz;
    public int puan=0;

    TextMeshProUGUI skor;

    private void Start()
    {
        skor = GameObject.Find("Canvas/skor").GetComponent<TextMeshProUGUI>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="elma")
        {
            puan += 10;
            Debug.Log(puan.ToString());
            skor.text = "skor=" + puan.ToString();
            float rnd = Random.Range(-14.80f, -3.25f);
            collision.gameObject.transform.position=new Vector3(6.91f, 8, rnd);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0, hiz * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, 0, -hiz * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, hiz * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -hiz * Time.deltaTime, 0);
        }
    }
}

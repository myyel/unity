using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    Transform mavi_kure;

    private void Start()
    {
        mavi_kure = GameObject.Find("oyuncu").transform;

        transform.parent = mavi_kure;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, mavi_kure.position, Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, mavi_kure.position, Time.deltaTime);

    }
}

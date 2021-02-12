using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    Transform oyuncu;
    private void Awake()
    {
        oyuncu = GameObject.Find("oyuncu").transform;
        Debug.Log("Buras� awake");
    }
    void Start()
    {
        Debug.Log("Buras� start");
    }

    private void OnEnable()
    {
        Debug.Log("Buras� onenable");
    }

    private void OnDisable()
    {
        Debug.Log("Buras� ondisable");
    }

    private void FixedUpdate()
    {
        transform.LookAt(oyuncu);
        Debug.Log("Buras� fixedupdate");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Buras� update");
    }

    private void LateUpdate()
    {
        Debug.Log("Buras� lateupdate");
    }
}

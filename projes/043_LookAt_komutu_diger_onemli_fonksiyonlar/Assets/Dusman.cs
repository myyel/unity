using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    Transform oyuncu;
    private void Awake()
    {
        oyuncu = GameObject.Find("oyuncu").transform;
        Debug.Log("Burasý awake");
    }
    void Start()
    {
        Debug.Log("Burasý start");
    }

    private void OnEnable()
    {
        Debug.Log("Burasý onenable");
    }

    private void OnDisable()
    {
        Debug.Log("Burasý ondisable");
    }

    private void FixedUpdate()
    {
        transform.LookAt(oyuncu);
        Debug.Log("Burasý fixedupdate");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Burasý update");
    }

    private void LateUpdate()
    {
        Debug.Log("Burasý lateupdate");
    }
}

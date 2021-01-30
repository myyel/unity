using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup_script : MonoBehaviour
{
    GameObject kup;
    MeshRenderer gorunurluk;
    kup_script kodlar;
    GameObject[] nesneler;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("kapsul").GetComponent<MeshRenderer>().enabled = false;

        GameObject.FindWithTag("Player").GetComponent<MeshRenderer>().enabled = false;

        nesneler = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject nesne in nesneler)
        {
            nesne.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

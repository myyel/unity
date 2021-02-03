using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class kup_script : MonoBehaviour
{
    public GameObject kure;
    // Start is called before the first frame update
    void Start()
    {
        GameObject yeni_kure = Instantiate(kure, new Vector3(2,10,10), Quaternion.identity);
        Destroy(yeni_kure, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

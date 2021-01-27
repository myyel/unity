using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_script : MonoBehaviour
{
    private TextMesh txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMesh>();
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            txt.text = txt.text+Input.inputString;
        }
    }
}

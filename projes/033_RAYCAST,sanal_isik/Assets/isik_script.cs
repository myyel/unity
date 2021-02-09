using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isik_script : MonoBehaviour
{
    RaycastHit nesne;

    // Update is called once per frame
    void Update()
    {
        /*if (Physics.Raycast(transform.position,-transform.right,out nesne,10.0f))
        {
            if (nesne.collider.gameObject.tag=="Player")
            {
                Debug.Log("ýþýk küreye çarptý");
            }
        }*/

        //Ray isik_yolla = GameObject.Find("Main Camera").GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        Ray isik_yolla = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(isik_yolla,out nesne))
        {
            if (nesne.collider.gameObject.tag == "Player")
            {
                Debug.Log("ýþýk küreye çarptý");
            }
        }
    }
}

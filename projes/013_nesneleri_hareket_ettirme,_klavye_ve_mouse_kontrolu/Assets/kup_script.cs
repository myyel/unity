using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup_script : MonoBehaviour
{
    private void Update()
    {
        // klavye tuþlarý ile hareket ettirme

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0, 2);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.Translate(0, 0, -2);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.transform.Translate(-2, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(1*Time.deltaTime, 0, 0);
        }

        // mouse tuþlarý tuþlarý ile hareket ettirme

        if (Input.GetMouseButton(0))
        {
            this.transform.Translate(0, 0, 2);
        }
        if (Input.GetMouseButton(1))
        {
            this.transform.Translate(0, 0, -2);
        }
        if (Input.GetMouseButton(0))
        {
            this.transform.Translate(-2, 0, 0);
        }
        if (Input.GetMouseButton(1))
        {
            this.transform.Translate(1*Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.Rotate(150*Time.deltaTime,300*Time.deltaTime,0,Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.left * 50 * Time.deltaTime;            // sahnenin eksenine göre hareket
            this.GetComponent<Rigidbody>().velocity = -this.transform.right * 50 * Time.deltaTime;   // kendi eksenine göre hareket
            this.GetComponent<Rigidbody>().velocity =  this.transform.up * 50 * Time.deltaTime;
            this.GetComponent<Rigidbody>().velocity =  this.transform.forward * 50 * Time.deltaTime;

            this.GetComponent<Rigidbody>().AddForce(transform.forward * 50 * Time.deltaTime);        // buna dikkat
        } 
    }
}

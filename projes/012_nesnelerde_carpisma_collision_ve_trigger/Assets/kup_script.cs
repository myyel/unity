using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup_script : MonoBehaviour
{
    // çarpma iþlemi anýnda bir kez çalýþýr
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("çarptý");
    }

    // çarpma iþlemi bittikten sonra bir kez çalýþýr
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("çarpma bitti");
    }

    // çarpma iþlemi anýnda sürekli çalýþýr
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("çarpýyor");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("çarpma bitti");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("çarpýyor");
    }
}

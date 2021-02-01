using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kup_script : MonoBehaviour
{
    // �arpma i�lemi an�nda bir kez �al���r
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�arpt�");
    }

    // �arpma i�lemi bittikten sonra bir kez �al���r
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�arpma bitti");
    }

    // �arpma i�lemi an�nda s�rekli �al���r
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�arp�yor");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("�arpma bitti");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�arp�yor");
    }
}

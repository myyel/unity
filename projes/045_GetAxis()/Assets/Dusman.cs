using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        float sag_sol_yon_oklari = Input.GetAxis("Horizontal");
        float asagi_yukari_yon_oklari = Input.GetAxis("Vertical");

        transform.Translate(sag_sol_yon_oklari * Time.deltaTime*10, 0, asagi_yukari_yon_oklari * Time.deltaTime*10, Space.World);
    }
}

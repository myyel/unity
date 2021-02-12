using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{

    public AudioSource ses_dosyasi;
    public AudioClip ses_yol;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("sesi_ac", 3);
    }

    public void sesi_ac()
    {
        ses_dosyasi.PlayOneShot(ses_yol, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

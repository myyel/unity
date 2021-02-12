using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dusman : MonoBehaviour
{
    public NavMeshAgent dusmanimiz;
    Transform oyuncumuz;
    // Start is called before the first frame update
    void Start()
    {
        oyuncumuz = GameObject.Find("oyuncu").transform;
    }

    // Update is called once per frame
    void Update()
    {
        dusmanimiz.destination = oyuncumuz.position;
    }
}

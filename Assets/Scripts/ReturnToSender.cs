using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToSender : MonoBehaviour
{

    private Vector3 StartPOS;
    private Rigidbody rbody;

    void Start()
    {
        StartPOS = transform.position;
        rbody = GetComponent<Rigidbody>();
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("KillTrigger"))
        {
            transform.position = StartPOS;
            if(rbody)
            {
                rbody.velocity = Vector3.zero;
            }
        }
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnFall : MonoBehaviour {


    private Vector3 StartPOS;
    public float Falling;
    void Start()
    {
        StartPOS = transform.position;
    }
    // Update is called once per frame
    void Update ()
    {
            if (transform.position.y < (-10))
            {
            transform.position = StartPOS;//Falling;
            }
    }
}

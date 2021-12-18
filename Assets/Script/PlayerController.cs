using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float move = 15f;
    public Rigidbody rd;
    
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float directional = Input.GetAxis("Horizontal");
        Vector3 motion = new Vector3(move * directional, 5f);
        rd.velocity = motion;
    }
}

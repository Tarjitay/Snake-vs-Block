using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float move = 15f;
    public Rigidbody rd;

    public int Length = 1;
    public TextMeshPro Number;
    public GameObject Food;
    public Game Game;

    private SnakeTail componentSnakeTail;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        componentSnakeTail = GetComponent<SnakeTail>();

        for (int i = 1; i < Length; i++) componentSnakeTail.AddSphere();

        Number.SetText(Length.ToString());
    }

    void Update()
    {
        float directional = Input.GetAxis("Horizontal");
        Vector3 motion = new Vector3(move * directional, 5f);
        rd.velocity = motion;

        //if (other.TryGetComponent(out Cube cube))
        //{
            //Length--;
            //componentSnakeTail.RemoveSphere();
            //Number.SetText(Length.ToString());
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Food food))
        {            
            Destroy(other.gameObject);

            Length++;
            componentSnakeTail.AddSphere();
            Number.SetText(Length.ToString());
        }
    }
}

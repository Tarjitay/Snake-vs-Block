using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform Snake;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Snake.transform.position;
    }

    void Update()
    {
        Vector3 transformPosition = new Vector3(0.79f, Snake.position.y + offset.y, Snake.position.z + offset.z);
        transform.position = transformPosition; 
    }
}

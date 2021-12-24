using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
        public GameObject victory;

    private void OnTriggerEnter(Collider other)
    {
        victory.SetActive(true);    
    }
}

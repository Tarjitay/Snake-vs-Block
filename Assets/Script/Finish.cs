using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //private void OnTriggerEnter(Collider other)
    //{
    //if (other.collider.TryGetComponent(out PlayerController PlayerController)) return;
    //PlayerController.ReachFinish();
    //}
    public GameObject victory;

    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        victory.SetActive(true);    
    }
}

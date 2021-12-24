using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ControleScene : MonoBehaviour
{
    public void NextLevel(int _123)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(_123);
    }


    //public void NextScene()
    //{
       //buttonNextLevel.SetActive(true);
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResControlsScene : MonoBehaviour
{
    public void NextLevel(int _123)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        //SceneManager.LoadScene(_123);
    }
}

using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public PlayerController PlayerController;
    public enum State
    {
        Playing,
        Won,
        //Loss,
    }

    public State CurrentState { get; private set; }

    //public void OnPlayerDied()
    //{
       // if (CurrentState != State.Playing) return;

       // CurrentState = State.Loss;
       // Controls.enabled = false;
       // Debug.Log("Game Over!");
       // ReloadLevel();
    //}

    //public void OnPlayerReachedFinish()
    //{
       // if (CurrentState != State.Playing) return;

        //CurrentState = State.Won;
        //PlayerController.enabled = false;
        //LevelIndex++;
        //Debug.Log("You won!");
        //ReloadLevel();
    //}

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }

    private const string LevelIndexKey = "LevelIndex";

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

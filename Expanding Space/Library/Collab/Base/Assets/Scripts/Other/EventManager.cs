using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void StartGameDelegate();
    public static StartGameDelegate onStartGame;
    public static StartGameDelegate onInstructionsGame;
    public static StartGameDelegate onBackGame;
    public static StartGameDelegate onNextGame;
    public static StartGameDelegate onPreviousGame;
    public static StartGameDelegate onPlayerDeath;
    public static StartGameDelegate onRespawnPickup;

    public delegate void TakeDamageDelegate(float amt);
    public static TakeDamageDelegate onTakeDamage;

    public delegate void ScorePointsDelegate(int amt);
    public static ScorePointsDelegate onScorePoints;

    public static void StartGame()
    {
       // Debug.Log("Start Game");
        if(onStartGame != null)
        {
            onStartGame();
        }
    }

    void Start()
    {

    }

    public static void InstructionsGame()
    {
         //Debug.Log("Instructions from Game");
        if (onInstructionsGame != null)
        {
            onInstructionsGame();
        }
    }


    public static void BackGame()
    {
        //Debug.Log("Back to menu");
        if (onBackGame != null)
        {
            onBackGame();
        }
    }

    public static void NextGame()
    {
        //Debug.Log("Back to menu");
        if (onNextGame != null)
        {
            onNextGame();
        }
    }

    public static void PreviousGame()
    {
        //Debug.Log("Back to menu");
        if (onPreviousGame != null)
        {
            onPreviousGame();
        }
    }


    public static void QuitGame()
    {
         //Debug.Log("Quit Game");
         Application.Quit();
    }


    public static void ReSpawnPickup()
    {
        // Debug.Log("Start Game");
        if (onRespawnPickup != null)
        {
            onRespawnPickup();
        }
    }


    public static void TakeDamage(float percent)
    {
      //  Debug.Log("Take Damage: " + percent);
        if (onTakeDamage != null)
        {
            onTakeDamage(percent);
        }
    }


    public static void PlayerDeath()
    {
        //Debug.Log("Player Died");
        if (onPlayerDeath != null)
        {
            onPlayerDeath();


        }

    }

    public static void ScorePoints(int score)
    {
        //  Debug.Log("Take Damage: " + percent);
        if (onScorePoints != null)
        {
            onScorePoints(score);
        }
    }


}
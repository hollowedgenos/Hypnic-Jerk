using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject gameOverScreen;
    [SerializeField] private GameObject levelCompleteScreen;
    [SerializeField] private GameObject powerUpGetKick;
    [SerializeField] private GameObject restartMessage;
    public bool powerUpKick;

    // Sets the all text objects to false when the game starts or resets.
    void Awake()
    {
        gameOverScreen.SetActive(false);
        levelCompleteScreen.SetActive(false);
        powerUpGetKick.SetActive(false);
        restartMessage.SetActive(false);
    }

    // Activate Game Over Screen and Restart Message
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        restartMessage.SetActive(true);
    }

    // Activate Level Complete Screen
    public void LevelComplete()
    {
        levelCompleteScreen.SetActive(true);
    }

    // Activate the text when acquiring the Kick Power Up
    public void PowerUpGetKick()
    {
        powerUpGetKick.SetActive(true);
        powerUpKick = true;
    }

}

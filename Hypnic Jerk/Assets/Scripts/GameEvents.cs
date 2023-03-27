using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEvents : MonoBehaviour
{

    private UIManager uiManager;
    [SerializeField] private Transform player;
    
    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            uiManager.GameOver();
            player.gameObject.GetComponent<Movement>().enabled = false;
        }

        if (collision.gameObject.CompareTag("Box"))
        {
            Destroy(gameObject);
            uiManager.GameOver();
            player.gameObject.GetComponent<Movement>().enabled = false;
        }
    }
}

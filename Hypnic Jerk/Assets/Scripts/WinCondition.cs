using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{

    private UIManager uiManager;
    [SerializeField] private GameObject player;
    private bool loadTheScene;

    void Start()
    {
        gameObject.SetActive(false);
        loadTheScene = false;
    }

    private void Update()
    {
        if (loadTheScene == true && (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1")))
        {
            SceneManager.LoadScene("Scenes/" + "Level2");
        }
        else if (loadTheScene == true && (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2")))
        {
            SceneManager.LoadScene("Scenes/" + "Credits");
        }
    }

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            uiManager.LevelComplete();
            loadTheScene = true;
        }
            
    }
}
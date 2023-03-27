using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpGetKick : MonoBehaviour
{

    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    // Checks if the player touches the power up
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            Player playerScript = player.GetComponent<Player>();
            uiManager.PowerUpGetKick();

            if (playerScript)
            {
                playerScript.kickAcquired = true;
                Destroy(gameObject);
            }
            
        }
    }
}

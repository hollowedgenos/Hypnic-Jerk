using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sproing : MonoBehaviour
{

    [SerializeField] private GameObject sproingSprite1;
    [SerializeField] private GameObject sproingSprite2;

    void Start()
    {
        // Show the sproing in its dormant state
        sproingSprite1.gameObject.SetActive(true);
        sproingSprite2.gameObject.SetActive(false);
    }

    // Check if an object collides with the sproing.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player or box collides with the sproing, object bounces.   
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 70), ForceMode2D.Impulse);
            // Show the sproing in its sprung state
            sproingSprite1.gameObject.SetActive(false);
            sproingSprite2.gameObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            StartCoroutine(Wait(.3f));
        }
    }

    IEnumerator Wait(float waitTime)
    {
        
        sproingSprite2.gameObject.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        sproingSprite2.gameObject.SetActive(false);
        sproingSprite1.gameObject.SetActive(true);
    }
}

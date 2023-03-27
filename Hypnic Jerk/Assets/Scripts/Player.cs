using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool kickAcquired;

    private float kickRange = 0.9f;
    public float knockBackForce = 15f;

    [SerializeField] private Transform keyCheck;
    [SerializeField] private LayerMask keyLayer;

    public ParticleSystem keyHit;
    public Transform hit;
    Key kickKey;

    void Start()
    {
        // Make the Key Script known to the player.
        kickKey = GameObject.FindGameObjectWithTag("Box").GetComponent<Key>();
        // Particle system for when the box is kicked.
        keyHit = gameObject.GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        // Checks if power up was acquired, the box (key) is in kicking range, and the attack key was pressed.
        if (kickAcquired == true && InRange() && Input.GetKeyDown(KeyCode.Z))
        {
            // Call the Kick Method from the Key Script.
            kickKey.Kick();
            hitParticle();
            // Play the particle effect after hitParticle() is called.
            keyHit.Play();
        }
    }

    // Checks via a circle overlap if the box is in range of the player.
    private bool InRange()
    {
        return Physics2D.OverlapCircle(keyCheck.position, kickRange, keyLayer);
    }

    // Creates a particle effect upon the box being kicked, is then immediately destroyed.
    void hitParticle()
    {
        ParticleSystem partInst = Instantiate(keyHit, hit);
        Destroy(partInst);
    }

    // The code for Kick PowerUp
    //void Kick()
    //{
    //    key.AddForce(transform.right * knockBackForce, ForceMode2D.Force);
    //}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    // Checks if power up was acquired and the attack key was pressed
    //    if (collision.gameObject.name == "TheKey")
    //    {
    //        if (kickAcquired == true && Input.GetKeyDown(KeyCode.Z))
    //        {
    //            key.velocity = new Vector2(knockBackForce, key.velocity.y);
    //            //key.AddForce(Vector2.right * knockBackForce, ForceMode2D.Force);
    //        } 

    //    }
    //}
}

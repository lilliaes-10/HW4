using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public float flapForce = 5f;
    public AudioSource flapSound;
    public AudioSource deathSound;

    public static event Action OnPlayerDeath;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);
            flapSound.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        deathSound.Play();
        OnPlayerDeath?.Invoke();
        enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("earned point");
        /*
        if (other.CompareTag("Player") && !scored)
        {
            scored = true;
            OnPipePassed?.Invoke();
        }
        */
    }
}

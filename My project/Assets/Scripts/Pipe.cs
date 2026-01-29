using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pipe : MonoBehaviour
{
    public float speed = 2f;
    private bool scored = false;

    public static event Action OnPipePassed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -10f)
            Destroy(gameObject);
    }
}
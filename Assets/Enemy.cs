using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movespeed = 3f;
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        rb.position += Vector2.left * Time.deltaTime * movespeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Score.point += 1;
    }
}

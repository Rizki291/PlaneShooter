using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public int life= 5;
    public Text txtlife;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    void Start()
    {
        txtlife.text = "Live:"+life;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        life -= 1;
        txtlife.text = "Live:" + life;
        if (life <= 0)
        {
            Time.timeScale = 0;
        }
    }
}

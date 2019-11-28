using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hiteffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

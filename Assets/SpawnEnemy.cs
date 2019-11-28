using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemypref;
    float time2 = 0.0f;
    int timer = 0;
    // Update is called once per frame
    void Update()
    {
        time2 += Time.deltaTime;
        timer = (int)time2 % 60;
        if (timer == 2)
        {
            spawn();
            time2 = 0.0f;
        }
    }
    void spawn()
    {
        Vector2 postition = new Vector2(transform.position.x,Random.Range(0,5));
        GameObject bullet = Instantiate(Enemypref, postition, transform.rotation);
    }
}

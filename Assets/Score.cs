using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int point = 0;
    public Text txtpoint;
    // Update is called once per frame
    void Update()
    {
        txtpoint.text = "" + point;
    }
}

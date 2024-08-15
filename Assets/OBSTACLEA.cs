using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBSTACLEA: MonoBehaviour
{
    public float movSpeed= 1f;
    float speedX;
    float speedY;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxis("Horizontal");
        transform.Translate(speedX, 0, 0);
    }
}

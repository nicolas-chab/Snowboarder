using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueamount = 1f;
    [SerializeField] float boostspeed = 30f;
    [SerializeField] float basespeed = 20f;
    Rigidbody2D rb2d;

    SurfaceEffector2D surfaceEffector2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
        respondtoboost();
    }

    void respondtoboost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostspeed;
        }
        else
        {
            surfaceEffector2D.speed = basespeed;
        }
    }

    void rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueamount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueamount);
        }
    }
}

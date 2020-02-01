﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private RaycastHit2D hit;
    private Rigidbody2D myRB;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.localScale.x > 0)
            {
                hit = Physics2D.Raycast(transform.position, Vector2.right);
                Debug.DrawRay(transform.position, Vector2.right, Color.red);
            }else if (transform.localScale.x < 0)
            {
                hit = Physics2D.Raycast(transform.position, Vector2.left);
                Debug.DrawRay(transform.position, Vector2.left, Color.red);
            }
        } 
    }
}

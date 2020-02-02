using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D myRB;
    private float h;
    private float v;
    private Animator myAnim;

    [SerializeField] private float moveSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector2 moving = new Vector2(h, v);

        if (h < 0 && transform.localScale.x != -2)
        {
            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        } else if (h > 0 && transform.localScale.x != 2)
        {
            Vector3 temp = transform.localScale;
            temp.x = 2;
            transform.localScale = temp;
        }
        
        myRB.AddForce(moving * moveSpeed);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Weapon"))
        {
            GameManager.PlayerHealth -= 25;
        }
    }
}

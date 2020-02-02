using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private RaycastHit2D hit;
    private Rigidbody2D myRB;
    private int layerMask;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        layerMask = 1 << 11;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.localScale.x > 0)
            {
                hit = Physics2D.Raycast(transform.position, Vector2.right,2, layerMask);
                Debug.DrawRay(transform.position, Vector2.right, Color.red);

                if (hit)
                {
                    if (hit.collider.CompareTag("Enemy") || hit.collider.CompareTag("Weapon"))
                    {
                        hit.collider.gameObject.GetComponentInParent<EnemyMove>().health -= 1;
                    }
                }
            }else if (transform.localScale.x < 0)
            {
                hit = Physics2D.Raycast(transform.position, Vector2.left,2,layerMask);
                Debug.DrawRay(transform.position, Vector2.left, Color.red);
                if (hit)
                {
                    if (hit.collider.CompareTag("Enemy") || hit.collider.CompareTag("Weapon"))
                    {
                        hit.collider.gameObject.GetComponentInParent<EnemyMove>().health -= 1;
                    }
                }
            }
        }

       
    }
}

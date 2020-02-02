using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject keep;
    private Rigidbody2D myRB;
    private Vector2 direction;
    [SerializeField] private int speed = 1;
    private RaycastHit2D hit;
    private int layerMask = 1 << 8;
    private Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        direction = keep.transform.position - transform.position;
        Vector2 temp = transform.localScale;
        temp.x *= direction.normalized.x;
        transform.localScale = temp;
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(transform.position, direction ,1, layerMask);
        if (!hit)
        {
            transform.position =
                Vector2.MoveTowards(transform.position, keep.transform.position, speed * Time.deltaTime);
            myAnim.SetBool("Attack", false);
        }
        else
        {
            myAnim.SetBool("Attack", true);
        }
    }
}

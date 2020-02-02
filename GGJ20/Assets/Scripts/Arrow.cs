using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody2D myRB;
    public Transform arrowParent;

    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(GameObject.Find("Arrow Parent").transform);
        myRB = GetComponent<Rigidbody2D>();
        myRB.AddForce(transform.right * 500);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyMove>().health -= 1;
        }
    }
}

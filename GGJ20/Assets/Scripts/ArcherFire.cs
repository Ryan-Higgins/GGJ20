using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherFire : MonoBehaviour
{
    private Animator myAnim;
    public GameObject arrow;
    public Transform arrowSpawn;
    private bool delayFire = true;
    public Transform aimingAt;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            myAnim.SetBool("Attack", true);
            StartCoroutine(Delay());
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (!delayFire)
            {
                Instantiate(arrow, arrowSpawn);
                delayFire = true;
                StartCoroutine(Delay());
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.1f);
        delayFire = false;
    }
}

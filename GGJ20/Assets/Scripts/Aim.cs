using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private ArcherFire myAim;
    private Transform target;
    private Vector2 toTarget;
    
    // Start is called before the first frame update
    void Start()
    {
        myAim.GetComponentInParent<ArcherFire>();
        target = myAim.aimingAt;
    }

    // Update is called once per frame
    void Update()
    {
        toTarget = target.position - transform.position;
        float angle = Mathf.Atan2(toTarget.y, toTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 10);
    }
}

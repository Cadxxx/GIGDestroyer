using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject projectile;
    public float force;
    public float interval;
    private DateTime lastFired;

    // Start is called before the first frame update
    void Start()
    {
        lastFired = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;

        if((now - lastFired).TotalMilliseconds >= interval)
        {
            GameObject go = Instantiate(projectile, this.transform);
            go.transform.parent = null;
            go.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1) * force);
            lastFired = now;
            Destroy(go, 5);
        }
    }
}

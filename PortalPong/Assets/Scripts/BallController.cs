using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
    public Rigidbody rbd;
    public Vector3 acceleration;
    public Vector3 vel;

    private void Awake()
    {
        rbd = GetComponent<Rigidbody>();
        rbd.AddForce(vel);
    }

    private void FixedUpdate()
    {
        rbd.AddForce(acceleration);
    }
}

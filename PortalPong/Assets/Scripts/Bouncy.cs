using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallMover ball = other.GetComponent<BallMover>();
        if (ball)
        {
            Rigidbody rbd = ball.rbd;
            Vector3 force = other.transform.right * ball.rbd.velocity.magnitude * 2;
            force = ball.rbd.velocity.x > 0 ? -force : force;
            rbd.velocity += force;
        }
    }
}

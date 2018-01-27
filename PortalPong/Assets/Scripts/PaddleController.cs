using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    [Range(0, 1)]
    public float friction;

    private float vel;

    private void OnTriggerEnter(Collider other)
    {
        BallController ball = other.GetComponent<BallController>();
        Rigidbody rbd = ball.rbd;
        Vector3 force = other.transform.right * ball.rbd.velocity.magnitude * 2;
        Vector3 newForce = Vector3.Lerp(force, new Vector3(0, vel * friction), 0.5f) * 2;
        rbd.velocity += newForce;
    }

    private void Update()
    {
        vel = 0;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
            vel += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
            vel -= speed;
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class BallMover : MonoBehaviour
{
    public Rigidbody rbd;
    public Vector3 acceleration;
    public Vector3 vel;
    private AudioSource audioSource;

    private void Awake()
    {
        rbd = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        rbd.AddForce(vel);
    }

    private void FixedUpdate()
    {
        rbd.AddForce(acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.panStereo = transform.position.x / 10;
        audioSource.Play();
    }
}

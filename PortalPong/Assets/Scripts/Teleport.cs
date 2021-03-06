﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public AudioSource enterAudio;
    public AudioSource exitAudio;
    public float teleportCooldown = 1.0f;
    public bool UseOffset = true;

    private float timeSinceLastTeleport = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastTeleport += Time.deltaTime;
	}

    private void OnTriggerEnter(Collider other)
    {
        Vector3 offset = other.transform.position - transform.position;
        PortalConnection portal = other.GetComponent<PortalConnection>();

        if (portal != null && timeSinceLastTeleport > teleportCooldown)
        {
            
            Transform destination = portal.destination.transform;
            if (UseOffset)
            {
                transform.position = destination.position - offset;
            }
            else
            {
                transform.position = destination.position;
            }
            //transform.rotation = destination.rotation;
            timeSinceLastTeleport = 0.0f;

            enterAudio.panStereo = other.transform.position.x / 10;
            enterAudio.Play();
            //exitAudio.panStereo = portal.transform.position.x / 10;
            //exitAudio.Play();
        }
    }
}

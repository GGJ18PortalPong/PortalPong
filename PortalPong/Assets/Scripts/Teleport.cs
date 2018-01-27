using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public float teleportCooldown = 1.0f;
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
            transform.position = destination.position - offset;
            transform.rotation = destination.rotation;
            timeSinceLastTeleport = 0.0f;
        }

        
    }
}

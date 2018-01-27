using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject spawnObject;
    public float repeatRate = 1.0f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", repeatRate, repeatRate);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void Spawn ()
    {
        GameObject.Instantiate(spawnObject,transform.position,transform.rotation);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMove : MonoBehaviour {
    public float speed = 5.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.up * Time.deltaTime * speed * -1, Space.World);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        BallMover ball = other.gameObject.GetComponent<BallMover>();
        if (ball)
        {
            audioManager.AddSignal();
            //Destroy(ball.gameObject);
            SceneController.LoadNextLevel();
        }
    }
}

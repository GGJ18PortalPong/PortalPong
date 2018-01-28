using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public AudioManager audioManager;
    public ParticleSystem explosion;
    AudioSource audioSource;
    public float delay = 2.0f;

    public void Explode(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
    }

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        BallMover ball = other.gameObject.GetComponent<BallMover>();
        if (ball)
        {
            
            Explode(transform.position);
            Destroy(ball.gameObject);
            audioSource.Play();
            Invoke("NextLevel", delay);
            if (audioManager != null)
            {
                audioManager.AddSignal();
            }
        }
    }
    private void NextLevel()
    {
        SceneController.LoadNextLevel();
    }
}

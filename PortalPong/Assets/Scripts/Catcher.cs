using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public AudioManager audioManager;
    public ParticleSystem explosion;
    public float delay = 2.0f;

    public void Explode(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
    }

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        BallMover ball = other.gameObject.GetComponent<BallMover>();
        if (ball)
        {
            //audioManager.AddSignal();
            Explode(transform.position);
            Destroy(ball.gameObject);
            Invoke("NextLevel", delay);
        }
    }
    private void NextLevel()
    {
        SceneController.LoadNextLevel();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallMover ball = other.gameObject.GetComponent<BallMover>();
        if (ball)
        {
            //Destroy(ball.gameObject);
            SceneController.LoadNextLevel();
        }
    }
}

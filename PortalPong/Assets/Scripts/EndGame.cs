using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public float loadDelay = 5.0f;

    // Use this for initialization
    private void Awake()
    {
        Invoke("Restart", loadDelay);
    }

    private void Restart()
    {
        SceneController.LoadTitle();
    }
}

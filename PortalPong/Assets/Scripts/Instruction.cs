using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour {
    public float loadSceneDelay = 15.0f;

    private void Awake()
    {
        Invoke("LoadNextLevel", loadSceneDelay);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        SceneController.LoadNextLevel();
    }
}

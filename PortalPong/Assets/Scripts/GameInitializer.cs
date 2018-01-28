using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour {

    public GameObject sceneControllerPrefab;
    public GameObject audioManagerPrefab;
    public float loadDelay = 5.0f;
    //private SceneController sceneController;

    private void Awake()
    {
        /*sceneController = GameObject.FindObjectOfType<SceneController>();

       if (sceneController == null)
       {
           sceneController = GameObject.Instantiate(sceneControllerPrefab).GetComponent<SceneController>();
       }
       */
        GameObject obj = GameObject.FindGameObjectWithTag("AudioManager");
        AudioManager audioManager;
        if (obj == null)
        {
            audioManager = GameObject.Instantiate(audioManagerPrefab).GetComponent<AudioManager>();
        }
        else
        {
            audioManager = obj.GetComponent<AudioManager>();
            audioManager.ResetAudio();
        }
        Invoke("NextLevel", loadDelay);
    }

    void NextLevel()
    {
        SceneController.LoadNextLevel();
    }
}

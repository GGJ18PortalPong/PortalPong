using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour {

    public GameObject sceneControllerPrefab;
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
        Invoke("NextLevel", loadDelay);
    }

    void NextLevel()
    {
        SceneController.LoadNextLevel();
    }
}

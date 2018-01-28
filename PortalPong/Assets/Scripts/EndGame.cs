using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public float loadDelay = 5.0f;
    public Text timeText;

    private string timeTextString = "Time Taken: ";


    // Use this for initialization
    private void Awake()
    {
        if (timeText != null)
        {
            if (Timer.startTime > -1.0f)
            {
                int timeTaken = (int)Time.time - (int)Timer.startTime;
                timeText.text = string.Concat(timeTextString, timeTaken.ToString());
            }
            else
            {
                timeText.enabled = false;
            }
        }
        Invoke("Restart", loadDelay);
    }

    private void Restart()
    {
        SceneController.LoadTitle();
    }
}

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

				float minutes = Mathf.Floor(timeTaken / 60);
				float seconds = Mathf.RoundToInt(timeTaken%60);
				string minutesString = minutes.ToString();
				string secondsString = seconds.ToString();

				if(minutes < 10) {
					minutesString = "0" + minutes.ToString();
				}
				if(seconds < 10) {
					secondsString = "0" + Mathf.RoundToInt(seconds).ToString();
				}

				timeText.text = timeTextString + minutesString + ":" + secondsString;
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

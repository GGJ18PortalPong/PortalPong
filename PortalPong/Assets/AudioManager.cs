using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource signal1;
    public AudioSource signal2;
    public AudioSource signal3;
    public AudioSource noise;

    private void Start()
    {
        signal1.mute = true;
        signal2.mute = true;
        signal3.mute = true;
        noise.volume = 1;

        DontDestroyOnLoad(gameObject);
    }

    public void AddSignal()
    {
        noise.volume -= 1 / 3;
        if (signal1.mute)
        {
            signal1.mute = false;
        }
        else if (signal2.mute)
        {
            signal2.mute = false;
        }
        else if (signal3.mute)
        {
            signal3.mute = false;
        }
    }
}

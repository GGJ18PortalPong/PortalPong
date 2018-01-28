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
        signal1.Play();
        signal2.Play();
        signal3.Play();
        signal2.mute = true;
        signal3.mute = true;
        noise.volume = 1;

        DontDestroyOnLoad(gameObject);
    }

    public void ResetAudio()
    {
        signal1.Stop();
        signal2.Stop();
        signal3.Stop();
        signal2.mute = true;
        signal3.mute = true;
        noise.Play();
        noise.volume = 1;
    }

    public void AddSignal()
    {
        if (!signal1.isPlaying)
        {
            noise.volume = .5f;
            //signal1.Play();
            //signal2.Play();
            //signal3.Play();
        }
        else if (signal2.mute)
        {
            noise.volume = .25f;
            signal2.mute = false;
        }
        else if (signal3.mute)
        {
            signal3.mute = false;
            noise.Stop();
        }
    }
}

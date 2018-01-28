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
    public float defaultMaxVol = 0.2f;

    private void Start()
    {
        signal1.Play();
        signal2.Play();
        signal3.Play();
        signal1.volume = defaultMaxVol;
        signal2.volume = defaultMaxVol;
        signal3.volume = defaultMaxVol;
        signal1.mute = true;
        signal2.mute = true;
        signal3.mute = true;
        noise.volume = defaultMaxVol;

        DontDestroyOnLoad(gameObject);
    }

    public void ResetAudio()
    {
        signal1.Stop();
        signal2.Stop();
        signal3.Stop();
        signal1.Play();
        signal2.Play();
        signal3.Play();
        signal1.mute = true;
        signal2.mute = true;
        signal3.mute = true;
        noise.Play();
        noise.volume = defaultMaxVol;
    }

    public void AddSignal()
    {
        if (signal1.mute)
        {
            noise.volume = defaultMaxVol / 2;
            signal1.mute = false;
            
        }
        else if (signal2.mute)
        {
            noise.volume = defaultMaxVol / 3;
            signal2.mute = false;
        }
        else if (signal3.mute)
        {
            signal3.mute = false;
            noise.Stop();
        }
    }
}

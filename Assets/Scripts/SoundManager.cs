using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource MusicSource;
    public AudioSource SoundSource;
    public AudioSource NarrationSource;

    public static SoundManager Instance = null;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance!=this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void PlayMusic(AudioClip _clip)
    {
        MusicSource.clip = _clip;
        MusicSource.Play();
    }
    public void PlaySound(AudioClip _clip)
    {
        SoundSource.clip = _clip;
        SoundSource.Play();
    }
    public void PlayNarration(AudioClip _clip)
    {
        NarrationSource.clip = _clip;
        NarrationSource.Play();
    }

   
}

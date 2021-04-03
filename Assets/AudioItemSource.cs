using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioItemSource : MonoBehaviour

{
    private string audioName;
    private bool isPlaying;

    public string AudioName
    {
        get { return this.audioName; }
        set { this.audioName = value; }
    }
    public bool IsPlaying
    {
        get { return this.isPlaying; }
        set { this.isPlaying = value; }
    }
    public void Play()
    {
        this.GetComponent<AudioSource>().Play();
    }
}

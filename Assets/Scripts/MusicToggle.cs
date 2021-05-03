// created by Katoshia Grubb

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//[RequireComponent(typeof(Toggle))]
public class MusicToggle : MonoBehaviour
{
    Toggle musicToggle;

    private void Start()
    {
        musicToggle = GetComponent<Toggle>();
        if (AudioListener.volume == 0)
        {
            musicToggle.isOn = false;
        }
    }
    public void ToggleAudioValueChange(bool audioIn)
    {
        if (audioIn)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Toggle))]
public class MusicToggle : MonoBehaviour
{
    Toggle musicToggle;
    public AudioSource musicSource;
    public AudioClip myMusic;


    //Start is called before the first frame update
    public void Start()
    {
        SoundManager.Instance.PlayMusic(myMusic);
        musicToggle = GetComponent<Toggle>();
        //musicToggle = SoundManager.Instance()
        if (AudioListener.volume == 0)
        {
            musicToggle.isOn = false;
        }
    }
    public void ToggleisOnValueChange(bool audio)
    {
        //SoundManager.Instance.PlayMusic(myMusic);

        if (audio)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}

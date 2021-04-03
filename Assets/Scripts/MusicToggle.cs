using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Toggle))]
public class MusicToggle : MonoBehaviour
{
    //    Toggle musicToggle;
    //    public AudioSource musicSource;
    //    public AudioClip myMusic;


    ////Start is called before the first frame update
    //public void Start()
    //{
    //    SoundManager.Instance.PlayMusic(myMusic);
    //    musicToggle = GetComponent<Toggle>();
    //    //musicToggle = SoundManager.Instance()
    //    if (AudioListener.volume == 0)
    //    {
    //        musicToggle.isOn = false;
    //    }
    //}
    GameObject _largePrint;
    GameObject _musicToggle;
    GameObject _narration;
    GameObject _darkTheme;

    private void Start()
    {
        _largePrint = GameObject.Find("LargePrintToggle");
        _musicToggle = GameObject.Find("MusicToggle");
        _narration = GameObject.Find("NarrationToggle");
        _darkTheme = GameObject.Find("DarkThemeToggle");
    }
    // check for toggle values
    public void CheckLargePrintToggle() { }
    public void CheckMusicToggle() 
    {
        //if(_musicToggle.GetComponent<Toggle>().isOn == true)
        //{
        //    SoundManager.Instance.PlayMusic(TestMusic);
        //    AudioListener.volume = 1;
        //}
        //else
        //{
        //    AudioListener.volume = 0;
        //}
    }
    public void CheckNarrationToggle() { }
    public void CheckDarkThemeToggle() { }

    //public void ToggleisOnValueChange()
    //{
    //    //SoundManager.Instance.PlayMusic(myMusic);

    //    if (audio)
    //    {
    //        AudioListener.volume = 1;
    //    }
    //    else
    //    {
    //        AudioListener.volume = 0;
    //    }
    //}
}

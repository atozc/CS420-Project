using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System;

public class AudioMgr : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider musicVolume;
    public AudioMixer masterMixer;

    void Start()
    {
        masterMixer.GetFloat("Music", out float mvol);

        musicVolume.value = mvol;
    }

    public void MusicVolumeChanged()
    {
        masterMixer.SetFloat("Music", musicVolume.value);
    }

}

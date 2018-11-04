using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    private AudioSource sourceMusic;
    public Slider sliderMusic;

    public Slider sliderSoundFX;

    public Toggle toggleAds;

    void Start () {
        sourceMusic = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("MusicVolume")) {
            sliderMusic.value = PlayerPrefs.GetFloat("MusicVolume");
            sourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        }

        if (PlayerPrefs.HasKey("SoundFXVolume")) {
            sliderSoundFX.value = PlayerPrefs.GetFloat("SoundFXVolume");
        }

        if (PlayerPrefs.HasKey("Ads")) {
            string state = PlayerPrefs.GetString("Ads");
            toggleAds.isOn = Convert.ToBoolean(state);
        }
    }

    public void SliderMusic() {
        sourceMusic.volume = sliderMusic.value;
        PlayerPrefs.SetFloat("MusicVolume", sliderMusic.value);
    }

    public void SliderSoundFX(){
        PlayerPrefs.SetFloat("SoundFXVolume", sliderSoundFX.value);
    }

    public void ToggleAds() {
        bool state = toggleAds.isOn;
        PlayerPrefs.SetString("Ads", state.ToString());
    }
}

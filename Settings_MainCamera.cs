using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings_MainCamera : MonoBehaviour {

    private AudioSource sourceMusic;
    public GameObject Ads;

    void Start () {
        sourceMusic = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("MusicVolume")) {
            sourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        }

        if (PlayerPrefs.HasKey("Ads")) {
            string state = PlayerPrefs.GetString("Ads");
            if (state == "True") {
                Ads.SetActive(false);
            }

            if (state == "False") {
                Ads.SetActive(true);
            }
        }
    }
	
}

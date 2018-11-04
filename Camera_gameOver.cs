using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_gameOver : MonoBehaviour {

    public GameObject cameraGameOver;
    public AudioClip soundFail;
    new AudioSource audio;
    public float soundVolume;

    void Start(){
        NotificationCenter.DefaultCenter().AddObserver(this, "playerDead");
        audio = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("SoundFXVolume")) {
            soundVolume = PlayerPrefs.GetFloat("SoundFXVolume");
        } else {
            soundVolume = 1f;
        }
    }

    void playerDead(Notification notificacion){
        NotificationCenter.DefaultCenter().AddObserver(this, "disableCameraDead");
        cameraGameOver.SetActive(true);
         audio.Stop();
         AudioSource.PlayClipAtPoint(soundFail, Camera.main.transform.position, soundVolume);
    }
}

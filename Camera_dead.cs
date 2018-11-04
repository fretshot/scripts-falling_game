using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_dead : MonoBehaviour {

    public AudioClip soundFail;
    public GameObject cameraDead;
    public float soundVolume;

    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "activateCameraDead");
        NotificationCenter.DefaultCenter().AddObserver(this, "disableCameraDead");

        if (PlayerPrefs.HasKey("SoundFXVolume")) {
            soundVolume = PlayerPrefs.GetFloat("SoundFXVolume");
        } else {
            soundVolume = 1f;
        }

    }

    void activateCameraDead(Notification notificacion){
        AudioSource.PlayClipAtPoint(soundFail, Camera.main.transform.position, soundVolume);
        cameraDead.SetActive(true);
        
    }

    void disableCameraDead(Notification notificacion){
        cameraDead.SetActive(false);
        
    }
}

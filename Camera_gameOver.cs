using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_gameOver : MonoBehaviour {

    public GameObject cameraGameOver;
   
    public AudioClip soundFail;
    new AudioSource audio;

    void Start(){
        NotificationCenter.DefaultCenter().AddObserver(this, "playerDead");
        audio = GetComponent<AudioSource>();
    }

    void playerDead(Notification notificacion){
        cameraGameOver.SetActive(true);
        audio.Stop();
        AudioSource.PlayClipAtPoint(soundFail, Camera.main.transform.position, 1f);
    }
}

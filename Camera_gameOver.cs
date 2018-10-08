using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_gameOver : MonoBehaviour {

    public GameObject cameraGameOver;

    void Start(){
        NotificationCenter.DefaultCenter().AddObserver(this, "playerDead");
    }

    void playerDead(Notification notificacion){
        cameraGameOver.SetActive(true);
    }
}

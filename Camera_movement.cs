using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour {

    public float speed = 3;

    void Start(){
        NotificationCenter.DefaultCenter().AddObserver(this, "increaseCameraSpeed");
    }

    void Update () {
        if (Player_Control.inMovement == true){
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    void increaseCameraSpeed(Notification notification){
        speed = (float)notification.data;
    }
}

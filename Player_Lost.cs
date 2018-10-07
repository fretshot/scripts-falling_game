using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Lost : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            Destroy(other.gameObject);
            Player_Control.inMovement = false;
            NotificationCenter.DefaultCenter().PostNotification(this, "playerDead");
        }
    }
}

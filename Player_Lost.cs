using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Lost : MonoBehaviour {

    GameObject player;

    private void Start(){
       player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            player.transform.position = GameObject.Find("RespawnPoint1").transform.position;
            Score.lives = Score.lives -1;
            NotificationCenter.DefaultCenter().PostNotification(this, "updateUILives");
            NotificationCenter.DefaultCenter().PostNotification(this, "activateCameraDead");
            Player_Control.inMovement = false;
            player.SetActive(false);
            Invoke("newVoid", 0.5f);
            if (Score.lives <= 0) {
                Destroy(other.gameObject);
                Player_Control.inMovement = false;
                NotificationCenter.DefaultCenter().PostNotification(this, "playerDead");
                NotificationCenter.DefaultCenter().PostNotification(this, "disableCameraDead");
            }
        }
    }

    void newVoid(){
        if(Score.lives > 0) {
            Player_Control.inMovement = true;
            player.SetActive(true);
            NotificationCenter.DefaultCenter().PostNotification(this, "disableCameraDead");
        }
    }
}

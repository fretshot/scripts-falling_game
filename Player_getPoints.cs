using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_getPoints : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other){

        if (other.tag == "coinGold"){
            Destroy(other.gameObject);
            NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 10);
        }

        if (other.tag == "coinSilver"){
            Destroy(other.gameObject);
            NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 5);
        }

        if (other.tag == "coinBronze"){
            Destroy(other.gameObject);
            NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 3);
        }
    }
}

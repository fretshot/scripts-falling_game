using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_getPoints : MonoBehaviour {

    public AudioClip soundCoin;
    public float soundVolume = 1f;

    void OnTriggerEnter2D(Collider2D other){

        if (other.tag == "coinGold"){
            Destroy(other.gameObject);
            NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 10);
            AudioSource.PlayClipAtPoint(soundCoin, Camera.main.transform.position, soundVolume);
        }

        if (other.tag == "coinSilver"){
            Destroy(other.gameObject);
            NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 5);
            AudioSource.PlayClipAtPoint(soundCoin, Camera.main.transform.position, soundVolume);
        }

        if (other.tag == "coinBronze"){
            Destroy(other.gameObject);
            NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 3);
            AudioSource.PlayClipAtPoint(soundCoin, Camera.main.transform.position, soundVolume);
        }
    }
}

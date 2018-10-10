using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_Platforms : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other){

        //Make sure, add a Rigidbidy2D to the box collider, set gravity scale to 0 and make it Dinamic
        if (other.tag == "Platform" || other.tag == "coinGold" || other.tag == "coinSilver" || other.tag == "coinBronze" || other.tag == "spikes") {
            Destroy(other.gameObject);
        }
                
    }
}

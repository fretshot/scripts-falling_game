using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_getPoints : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision){
        NotificationCenter.DefaultCenter().PostNotification(this, "winPoints", 1);
    }
}

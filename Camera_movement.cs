using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour {

    public int speed = 3;
    
    void Start () {
		
	}
	
	void Update () {
        if (Player_Control.inMovement == true){
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}

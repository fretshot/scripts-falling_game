using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour {

    public float speed = 3.0F;

    private void Start(){
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    void Update(){
        if (Input.touchCount > 0){
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2 ){
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else if (touch.position.x > Screen.width / 2 ){
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }



    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_heart : MonoBehaviour {

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }


    void GoBall(){
        float rand = Random.Range(0, 2);
        if (rand < 1){
            rb2d.AddForce(new Vector2(20, -15));
        }
        else{
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }

    void OnCollisionEnter2D(Collision2D coll){
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;
    }

    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }

    void ResetBall(){
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
}

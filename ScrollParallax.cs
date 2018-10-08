using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollParallax : MonoBehaviour {

    public float speed = 0f;
    private float initialTime = 0f;

    void Start(){
        initialTime = Time.time;
    }

    void Update () {
        gameObject.GetComponent<Renderer>();
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(((Time.time - initialTime) * speed) % 1, 0);
    }
}

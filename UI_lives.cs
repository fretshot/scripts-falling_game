using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_lives : MonoBehaviour {

    public GameObject[] lives;

    void Start () {
        Instantiate(lives[Random.Range(0, lives.Length)], transform.position, Quaternion.identity);
    }
}

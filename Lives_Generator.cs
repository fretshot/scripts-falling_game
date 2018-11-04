using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives_Generator : MonoBehaviour {

    public GameObject[] lives;
    public float tiempoMin = 60.0f;
    public float tiempoMax = 180.0f;
    public bool called = false;

    private void Update(){
        if (Player_Control.inMovement == true) {
            if (!called) {
                Invoke("iniciar", 10);
                called = true;
            }
        }
    }

    void Generar(){
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        Instantiate(lives[Random.Range(0, lives.Length)], transform.position, Quaternion.identity);
    }

    void iniciar(){
        Generar();
    }
}

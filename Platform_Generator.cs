using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Generator : MonoBehaviour {

    public GameObject[] platforms;
    public float tiempoMin = 1.25f;
    public float tiempoMax = 2.5f;

    public bool called = false;

   
    private void Update(){
        if(Player_Control.inMovement == true){
            if (!called){
                Generar();
                called = true;
            }
        } 
    }

    
    void Generar(){
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        Instantiate(platforms[Random.Range(0, platforms.Length)], transform.position, Quaternion.identity);
        if (Player_Control.inMovement == false) {
            CancelInvoke();
        }
            
    }
}

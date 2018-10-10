using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Play : MonoBehaviour{

    void OnMouseDown(){
        SceneManager.LoadScene("MainScene"); 
    }
}
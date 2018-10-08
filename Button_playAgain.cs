using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_playAgain : MonoBehaviour{

    void OnMouseDown(){
        SceneManager.LoadScene("MainScene");
    }
}
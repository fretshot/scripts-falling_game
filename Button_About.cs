using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_About : MonoBehaviour {

    void OnMouseDown(){
        SceneManager.LoadScene("AboutScene");
    }
}

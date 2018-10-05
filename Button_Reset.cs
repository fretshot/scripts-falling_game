using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Reset : MonoBehaviour {

    public Button ButtonRestartScene;
    

    void Start(){
        ButtonRestartScene.GetComponent<Button>();
        ButtonRestartScene.onClick.AddListener(Reload);
       
    }

    void Reload(){
        SceneManager.LoadScene("MainScene");
    }


}

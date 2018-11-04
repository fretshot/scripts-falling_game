using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public void clickButtonPlay(){
        SceneManager.LoadScene("MainScene");
    }

    public void clickButtonSettings(){
        SceneManager.LoadScene("SettingsScene");
    }

    public void clickButtonExit(){
        Application.Quit();
    }

    public void clickButtonBackWelcomeScene(){
        SceneManager.LoadScene("WelcomeScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int score;
    public static int lives = 2;
    public TextMesh scoreTextUI;
    public TextMesh maxScoreUI;
    public TextMesh livesUI;

    void Start(){
        lives = 2;
        updateScoreTextUI();
        updatelivesUI();
        NotificationCenter.DefaultCenter().AddObserver(this, "winPoints");
        NotificationCenter.DefaultCenter().AddObserver(this, "playerDead");
        NotificationCenter.DefaultCenter().AddObserver(this, "updateUILives");
    }

    void playerDead(Notification notificacion){
        if (score > Game_State.game_state.maxScore){
            Game_State.game_state.maxScore = score;
            Game_State.game_state.saveData();
        }
        updatelivesUI();
    }

    void updateUILives(Notification notificacion){
        updatelivesUI();
    }

    void winPoints(Notification notificacion){
        int pointsWon = (int)notificacion.data;
        score = score + pointsWon;
        updateScoreTextUI();

        if (score > 15 && score < 25){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 2.4f); 
        }

        if (score > 25 && score < 50) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",2.6f);
        }

        if (score > 50 && score < 75) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",2.8f);
        }

        if (score > 75 && score < 100) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",3.0f);
        }

        if (score > 100 && score < 125) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 3.2f);
        }

        if (score > 125 && score < 150) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 3.4f); 
        }

        if (score > 150 && score < 175) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",3.6f);
        }

        if (score > 175 && score < 200) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 3.8f);
        }

        if (score > 200 && score < 225) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.0f);
        }

        if (score > 225 && score < 250) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.3f);
        }

        if (score > 225 && score < 300) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.5f);
        }

        if (score > 300) {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 5.0f);
        }
    }

    void updateScoreTextUI(){
        scoreTextUI.text = score.ToString();
    }

    void updatelivesUI(){
        livesUI.text = lives.ToString();
    }


}

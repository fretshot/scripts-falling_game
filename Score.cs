using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int score;
    public TextMesh scoreTextUI;
    public TextMesh maxScoreUI;

    void Start(){
        updateScoreTextUI();
        updateMaxScoreUI();
        NotificationCenter.DefaultCenter().AddObserver(this, "winPoints");
        NotificationCenter.DefaultCenter().AddObserver(this, "playerDead"); 
    }

    void playerDead(Notification notificacion){
        if (score > Game_State.game_state.maxScore){
            Game_State.game_state.maxScore = score;
            Game_State.game_state.saveData();
        }
    }

    void winPoints(Notification notificacion){
        int pointsWon = (int)notificacion.data;
        score = score + pointsWon;
        updateScoreTextUI();

        if (score > 15){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 3.15f);
        }

        if (score> 25){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",3.2f);
        }

        if (score > 50){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",3.4f);
        }

        if (score > 75){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed",3.6f);
        }

        if (score > 100){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 3.8f);
        }

        if (score > 125){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.0f);
        }

        if (score > 150){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.2f);
        }

        if (score > 175){
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.4f);
        }

        if (score > 200)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseCameraSpeed", 4.6f);
        }

    }

    void updateScoreTextUI(){
        scoreTextUI.text = score.ToString();
    }

    public void updateMaxScoreUI(){
        maxScoreUI.text ="Best: "+ Game_State.game_state.maxScore.ToString();
    }
}

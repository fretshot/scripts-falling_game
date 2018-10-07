using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int score;
    public TextMesh scoreTextUI;
    public TextMesh maxScoreUI;

    void Start(){
   
        NotificationCenter.DefaultCenter().AddObserver(this, "winPoints");
        NotificationCenter.DefaultCenter().AddObserver(this, "playerDead");
        updateScoreTextUI();
        updateMaxScoreUI();
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
    }

    void updateScoreTextUI(){
        scoreTextUI.text = score.ToString();
    }

    void updateMaxScoreUI(){
        maxScoreUI.text = Game_State.game_state.maxScore.ToString();
    }
}

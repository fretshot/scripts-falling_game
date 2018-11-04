using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateValuesGameOver : MonoBehaviour {

    public TextMesh yourScore;
    public TextMesh bestScore;
    public Score score;
    

    void OnEnable(){
        yourScore.text = score.score.ToString();
        bestScore.text = Game_State.game_state.maxScore.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateValuesGameOver : MonoBehaviour {

    public TextMesh yourScore;
    public TextMesh bestScore;
    public Score score;
    public GameObject textNewRecord;

    void OnEnable(){
        yourScore.text = score.score.ToString();
        bestScore.text = Game_State.game_state.maxScore.ToString();

        if (score.score > Game_State.game_state.maxScore){
            textNewRecord.SetActive(true);
        }
        else{
            textNewRecord.SetActive(false);
        }
    }
}

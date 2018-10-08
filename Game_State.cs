using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Game_State : MonoBehaviour {

    public int maxScore = 0;
    public static Game_State game_state;
    private String pathFile;

    void Awake(){
        
        pathFile = Application.persistentDataPath + "/data.dat";
        if (game_state == null){
            game_state = this;
            DontDestroyOnLoad(gameObject);
        }else if (game_state != this){
            Destroy(gameObject);
        }
        loadData();
    }

    void Start(){
        
        
    }


    public void saveData(){
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Create(pathFile);
        dataToSave data = new dataToSave();
        data.maxScore = maxScore;
        binaryFormatter.Serialize(file, data);
        file.Close();
    }

    void loadData(){
        if (File.Exists(pathFile)){
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(pathFile, FileMode.Open);
            dataToSave data = (dataToSave)binaryFormatter.Deserialize(file);
            maxScore = data.maxScore;
            file.Close();
        }
        else{
            maxScore = 0;
        }
    }
}

[Serializable]
class dataToSave{
    public int maxScore;
}
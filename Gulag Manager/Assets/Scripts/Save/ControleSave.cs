using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ControleSave
{
    public ControleData data;

    public string file = "player.txt";

    public void Save() {
        string json = JsonUtility.ToJson(data);
        WriteToFile(file, json);
    }

    public void Load(){
        //data = new ControleData();
        //string json = ReadFromFile(file);
       // JsonUtility.FromJsonOverwrite(json, data);
    }
    public void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter write = new StreamWriter(fileStream)) { 
            write.Write(json);
        }
    }
    private string ReadFromFile(string fileName) {

        string path = GetFilePath(fileName);
        if (File.Exists(path)) {
            using (StreamReader reader = new StreamReader(path)) {
                string json = reader.ReadToEnd();
                return json;
            }
        }else
            Debug.LogWarning("Arquivo não encontrado!");
        return "";

    }


    private string GetFilePath(string fileName) {
        return Application.persistentDataPath + "/" + fileName;
    }

}

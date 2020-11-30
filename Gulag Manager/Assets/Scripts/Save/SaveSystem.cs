using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveGulag (Gulag gulag) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gulag.mec";
        FileStream stream = new FileStream(path, FileMode.Create);

        GulagData dataGulag = new GulagData(gulag);

        formatter.Serialize(stream, dataGulag);
        stream.Close();
    }
    public static GulagData LoadGulag()
    {

        string path = Application.persistentDataPath + "/gulag.mec";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GulagData dataGulag = formatter.Deserialize(stream) as GulagData;
            stream.Close();

            return dataGulag;

        }
        else {
            Debug.LogError("Arquivo não encontrado em" + path);
            return null;
        }
    }
}

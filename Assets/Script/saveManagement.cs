using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class saveManagement : MonoBehaviour
{
    public static void SaveData(HighScore player)
    {
        string path = Application.persistentDataPath + "/lokanData.palePale";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        dataPlayer data = new dataPlayer(player);

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru: " + data.high_score) ;
    }


    public static dataPlayer LoadData()
    {
        string path = Application.persistentDataPath + "/lokanData.palePale";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            dataPlayer data = x.Deserialize(stram) as dataPlayer;
            stram.Close();
            Debug.Log("load");
            return data;
        }
        else
        {
            Debug.Log("unload");
            return null;
        }
    }
}

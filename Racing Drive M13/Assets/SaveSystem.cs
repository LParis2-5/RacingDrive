using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class SaveSystem
{

    public PersistentGameObject pgo;

  
    public static void CaptureState(object obj)
    {

        //A el Document

        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/leaderboard.inf";

        FileStream file = new FileStream(path, FileMode.Create);//Make Last Lap instead and make for solo.

        Debug.Log("A guardar" + obj);

        formatter.Serialize(file, obj);

        file.Close();

        Debug.Log("Guardat realitzat a la maquina!");

    }
    public static object RestoreState()
    {

        string path = Application.persistentDataPath + "/leaderboard.inf";

        Debug.Log("Inici Restore State");

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            Dictionary<string, object> salvatori = formatter.Deserialize(stream) as Dictionary<string, object>;

            Debug.Log(salvatori + "El agafat");

            stream.Close();

            return salvatori;


        }

        return null;

    }

}

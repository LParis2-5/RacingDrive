using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



public class PersistentGameObject : MonoBehaviour
{
   public Dictionary<string, object> saveDic;


    public void Start()
    {

    }


    public void loadState()
    {

        saveDic = (Dictionary<string, object>) SaveSystem.RestoreState();
        Debug.Log("Incii carega PGO");

        var sa = FindObjectsOfType<MonoBehaviour>().OfType<IsSavable>();
        foreach (IsSavable sba in sa)
        {
            Debug.Log("Load del Persistent");
            Debug.Log(saveDic[sa.ToString()]);
            sba.load(saveDic[sa.ToString()]);

        }
    }

    public void captureState()
    {
        saveDic = new Dictionary<string, object>();

        var ss = FindObjectsOfType<MonoBehaviour>().OfType<IsSavable>();
        foreach (IsSavable sav in ss)
        {
            Debug.Log("Key =" + ss.ToString());
            saveDic.Add(ss.ToString(), sav.save()); //Fer el save i lligar-ho tot amb un return del Dictionary .
           Debug.Log(saveDic[ss.ToString()]);


           // //Ara, guardar a fitxer i carregar staat.
        }

        Debug.Log("captura!");

        SaveSystem.CaptureState(saveDic);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[System.Serializable]

public class TimerUI : MonoBehaviour, IsSavable
{

    [SerializeField] TMP_Text velocitat;
    string tempo = "";
  public float totalTime = 0;
   public float min;
    public float seg;
     public float milsec;

    public LeaderboardData leaderboardData;

    public float StarterTime;

   public string smin;
    public string ssec;
    public string smilsec;

    public float lastTotal;
    float bestTime;

    // Start is called before the first frame update
    void Start()
    {

        StarterTime = Time.time;
        
    }



    // Update is called once per frame
    void Update()
    {
       if (SceneManager.GetActiveScene().name.Contains("Zukuba"))
        {

        

        totalTime = Time.time - StarterTime;

        min = Mathf.Floor(totalTime / 60);
        seg = Mathf.Floor(totalTime - min * 60);

        if (seg > 60)
        {
            //seg = 0; //Mirar perque es queda en el valor i com "Delayjar-lo"
        }

        milsec = totalTime - Mathf.Floor(totalTime);

        smin = min.ToString();
        ssec = seg.ToString();
        smilsec = milsec.ToString().Substring(2, 3);
        velocitat.text = smin + ":" + ssec + ":" + smilsec;

        }

        //totalTime = totalTime + (Mathf.Round(Time.deltaTime * 100)) / 100.0;
        //tempo = totalTime + "";
        //velocitat.text = tempo;
        //Debug.Log(lastTotal);
    }

    public void load(object obj)
     {


        leaderboardData.load(obj);
        Debug.Log("CARREGALEADERBOARD!");


    }

    public object save()
    {
        Dictionary<string, LeaderboardData> dic = new Dictionary<string, LeaderboardData>();
        dic.Add("Leader", leaderboardData);

      return leaderboardData; //S'envia tot el TimerUI objecte
    }
}

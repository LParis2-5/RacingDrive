using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimerUI : MonoBehaviour
{

    [SerializeField] TMP_Text velocitat;
    string tempo = "";
  public float totalTime = 0;
   public float min;
    public float seg;
     public float milsec;

    public float StarterTime;

    string smin;
    string ssec;
    string smilsec;

    // Start is called before the first frame update
    void Start()
    {

        StarterTime = Time.time;
        
    }



    // Update is called once per frame
    void Update()
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
        //totalTime = totalTime + (Mathf.Round(Time.deltaTime * 100)) / 100.0;
        //tempo = totalTime + "";
        //velocitat.text = tempo;
    }
}

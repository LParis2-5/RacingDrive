using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;

public class LapController : MonoBehaviour, IComparer<LapController>
{
    // Start is called before the first frame update

    [SerializeField] int totalCheckpoints = 0;
    public GameObject[] totalTriggers;
    public int triggerValue = 0;
    int numberOfLaps = 1;
    [SerializeField] TMP_Text lapText;
    [SerializeField] TimerUI timer;
    public int lapValue = 0;
    private int lapLimit = 1;
    [SerializeField] PersistentGameObject at;

    void Start()
    {
        totalTriggers =  GameObject.FindGameObjectsWithTag("Checkpoints");

        if (PlayerPrefs.GetInt("Laps") > 0) {

            lapLimit = PlayerPrefs.GetInt("Laps");


        }

        else
        {
            lapLimit = 1;
        }

        foreach (GameObject trigger in totalTriggers)
        {
            totalCheckpoints = totalCheckpoints + 3;
        }
        //Afegir total voltes amb variable
        lapText.text = "" + numberOfLaps + "/" + lapLimit;

    }

    // Update is called once per frame
    void Update()
    {

        if (totalCheckpoints < triggerValue || totalCheckpoints == triggerValue)
        {
            Debug.Log("New Lap!");
            triggerValue = 0;
            totalCheckpoints = 0;
            numberOfLaps++;
            foreach (GameObject trigger in totalTriggers)
            {
                totalCheckpoints = totalCheckpoints + 3;
            }

            if (this.gameObject.tag.Contains("Player"))
            {
                lapText.text = "" + numberOfLaps + "/" + lapLimit; //Only player
                timer.lastTotal = timer.totalTime;
                timer.StarterTime = Time.time;

                timer.leaderboardData.minutes = timer.smin;
                timer.leaderboardData.segons = timer.ssec;
                timer.leaderboardData.milsecond = timer.smilsec;

                at.captureState();
                at.loadState();
            }

            
        }



        if (numberOfLaps > lapLimit)
        {
            Debug.Log("FINSIH!");
            EditorSceneManager.LoadScene("Leaderboard", UnityEngine.SceneManagement.LoadSceneMode.Single);
        }

        lapValue = (numberOfLaps * 100) + triggerValue;
    }

    public int Compare(LapController x, LapController y)
    {

        return x.lapValue.CompareTo(y.lapValue);

    }
}

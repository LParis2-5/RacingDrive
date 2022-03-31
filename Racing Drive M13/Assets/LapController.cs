using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int totalCheckpoints = 0;
    public GameObject[] totalTriggers;
    int numberOfLaps = 1;
    [SerializeField] TMP_Text lapText;
    [SerializeField] TimerUI timer;

    void Start()
    {
        totalTriggers =  GameObject.FindGameObjectsWithTag("Checkpoints");


        foreach (GameObject trigger in totalTriggers)
        {
            totalCheckpoints = totalCheckpoints + 3;
        }
        //Afegir total voltes amb variable
        lapText.text = "" + numberOfLaps;

    }

    // Update is called once per frame
    void Update()
    {

        if (totalCheckpoints < LapTrigger.triggerValue || totalCheckpoints == LapTrigger.triggerValue)
        {
            Debug.Log("New Lap!");
            LapTrigger.triggerValue = 0;
            totalCheckpoints = 0;
            numberOfLaps++;
            foreach (GameObject trigger in totalTriggers)
            {
                totalCheckpoints = totalCheckpoints + 3;
            }
            lapText.text = "" + numberOfLaps;
            timer.StarterTime = Time.time;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadLeaderboardData : MonoBehaviour
{

    public PersistentGameObject pgo;
    public TMP_Text leaderboard;
    public TimerUI UR;



    // Start is called before the first frame update
    void Start()
    {

        pgo.loadState();
        
    }

    // Update is called once per frame
    void Update()
    {
        leaderboard.text = "Ultima Volta = " + UR.leaderboardData.minutes + ":" + UR.leaderboardData.segons + ":" + UR.leaderboardData.milsecond;
    }
}

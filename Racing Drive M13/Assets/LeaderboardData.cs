using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class LeaderboardData:  IsSavable 
{

    public string minutes;
    public string segons;
    public string milsecond;

    public void load(object s)
    {
        LeaderboardData newD = (LeaderboardData)s;

        this.milsecond = newD.milsecond;
        this.segons = newD.segons;
        this.minutes = newD.minutes;



        Debug.Log("Carregada la info");

    }

    public object save()
    {
        Debug.Log("Guardada la info");


        LeaderboardData dataReturn = this;

        return dataReturn;
    }
}

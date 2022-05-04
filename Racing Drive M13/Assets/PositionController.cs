using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{

    public List<LapController> positions;
    public LapController[] controlers;
    int debig = 0;


    // Start is called before the first frame update
    void Start()
    {

        positions = new List<LapController>();


        foreach (LapController laps in controlers)
        {
            Debug.Log(laps);
            Debug.Log(laps.lapValue);
            debig = laps.lapValue;
            positions.Add(laps);

        }

    }

    // Update is called once per frame
    void Update()
    {

        foreach (LapController laps in controlers)
        {
            //Debug.Log(laps);

            positions.Sort(new PositionComparer());

            //Debug.Log(positions[3]); //Works in Reverse!

        }






    }
}

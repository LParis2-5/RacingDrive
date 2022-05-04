using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VoltaUIValues : MonoBehaviour
{

    public PositionController posControl;
    [SerializeField] public LapController playerControl;
    [SerializeField] public TMP_Text texto;

    // Start is called before the first frame update
    void Start()
    {

        
          
    }

    // Update is called once per frame
    void Update()
    {

       //Debug.Log(posControl.positions.IndexOf(playerControl));


        if (posControl.positions.IndexOf(playerControl) == 3)
        {
            texto.text = 1 + "/" + posControl.positions.Count;
        }

        else if (posControl.positions.IndexOf(playerControl) == 2)
        {
            texto.text = 2 + "/" + posControl.positions.Count;
        }

        else if (posControl.positions.IndexOf(playerControl) == 1)
        {
            texto.text = 3 + "/" + posControl.positions.Count;
        }

        else if (posControl.positions.IndexOf(playerControl) == 0)
        {
            texto.text = 4 + "/" + posControl.positions.Count;
        }

    }
}

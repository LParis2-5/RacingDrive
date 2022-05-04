using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LappSetter : MonoBehaviour
{
    public TMP_InputField input;
    int lapValue = 1;
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

   public void getValue()
    {
        lapValue = int.Parse(input.text);
        PlayerPrefs.SetInt("Laps", lapValue);
        Debug.Log("Set laps at: " + PlayerPrefs.GetInt("Laps"));
    }



}

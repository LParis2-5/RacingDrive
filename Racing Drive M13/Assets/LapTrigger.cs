using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger : MonoBehaviour
{

    [SerializeField] public static int triggerValue;

    // Start is called before the first frame update
    void Start()
    {
     

        
    }

    // Update is called once per frame
    void Update()
    {
        //Desactivar
    }

    private void OnTriggerExit(Collider other)
    {
        triggerValue++;
        Debug.Log(triggerValue);

    }



}

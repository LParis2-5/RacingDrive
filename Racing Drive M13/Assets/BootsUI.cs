using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityStandardAssets.Vehicles.Car { 

public class BootsUI : MonoBehaviour
{
        OffRoadController offroadBooster;
        [SerializeField] GameObject carContainer;
        [SerializeField] TMP_Text bosText;

        // Start is called before the first frame update
        void Start()
        {
            offroadBooster = carContainer.GetComponent<OffRoadController>();
            InvokeRepeating("calculeBoost", 0.05f, 0.05f);
        }

      void calculeBoost()
        {
            bosText.text = "" + Mathf.Floor(offroadBooster.bootsAmount/10);
        }
}
}
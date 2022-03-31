using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityStandardAssets.Vehicles.Car
{
    public class GetSpeedScript : MonoBehaviour
    {
        [SerializeField] GameObject carContainer;
        CarController m_Car;
        [SerializeField] TMP_Text velocitat;
        string speed = "";


        // Start is called before the first frame update
        void Start()
        {

            m_Car = carContainer.GetComponent<CarController>();

            InvokeRepeating("calculeSpeed", 0.05f, 0.05f);

        }

        // Update is called once per frame
        void calculeSpeed()
        {
            velocitat.text = "" + Mathf.Floor(m_Car.CurrentSpeed * 10);

        }
    }
}
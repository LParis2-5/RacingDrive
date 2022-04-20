using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            float lt = CrossPlatformInputManager.GetAxis("Fire1");
            float rt = CrossPlatformInputManager.GetAxis("Fire2");


            if (Input.GetJoystickNames().Length == 0)
            {
                //Debug.Log("PC");
                m_Car.Move(h, v, v, handbrake);
            }
            else
            {
                //Debug.Log("Controller");
                m_Car.Move(h, lt, rt, handbrake);
            }

            if(Input.anyKeyDown)
            {
                Debug.Log(Input.inputString);
            }
       

#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}

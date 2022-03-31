using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class OffRoadController : MonoBehaviour
    {
        [SerializeField] OffRoaderWheel wheel1;
        [SerializeField] OffRoaderWheel wheel2;
        [SerializeField] OffRoaderWheel wheel3;
        [SerializeField] OffRoaderWheel wheel4;

        CarController m_Car;
        [SerializeField] GameObject carContainer;

        int sum;

    public int bootsAmount;

        // Start is called before the first frame update
        void Start()
        {
            m_Car = carContainer.GetComponent<CarController>();

        }

        // Update is called once per frame
        void Update()
        {

            sum = wheel1.touch + wheel2.touch + wheel3.touch + wheel4.touch;
            
            if (sum > 0)
            {
                m_Car.m_Rigidbody.drag = m_Car.v_initialDrag * 10;
            }

            else if (sum < 0)
            {
                bootsAmount++;
            }

            else
            {
                m_Car.m_Rigidbody.drag = m_Car.v_initialDrag;
                m_Car.m_Rigidbody.mass = m_Car.v_initialMass;

            }

            if (Input.GetKey(KeyCode.B) && bootsAmount > 0)
            {
                bootsAmount--;
                bootsAmount--;
               

                m_Car.m_Rigidbody.mass = m_Car.v_initialMass * 2; 
            }

            //Debug.Log(bootsAmount);


        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Car
{
    public class OffRoadDuplicate : MonoBehaviour
    {

        Ray rayLeft = new Ray();
        RaycastHit hit;
        [SerializeField] Transform raystart;
        CarController m_Car;
        [SerializeField] GameObject carContainer;

        bool isTouching = false;

        // Start is called before the first frame update
        void Start()
        {
            m_Car = carContainer.GetComponent<CarController>();
        }

        // Update is called once per frame
        void Update()
        {
            OffRoad();
        }

        private void OnDrawGizmos()
        {

        }

        void OffRoad()
        {



            rayLeft.origin = raystart.position;
            rayLeft.direction = Vector3.down;

            Debug.DrawRay(rayLeft.origin, rayLeft.direction, Color.green);


            if (Physics.Raycast(rayLeft, out hit, 10f))
            {


                if (hit.collider.gameObject.name == "Terrain")
                {
                    m_Car.m_Rigidbody.drag = m_Car.v_initialDrag * 10;
                    Debug.DrawRay(rayLeft.origin, rayLeft.direction, Color.red);
                    //Variable si toc;

                    isTouching = true;
                }

                else
                {
                    m_Car.m_Rigidbody.drag = m_Car.v_initialDrag;

                    isTouching = false;
                }


                if (isTouching)
                {
                    m_Car.m_Rigidbody.drag = m_Car.v_initialDrag * 10;

                }


            }

        }


    }
}
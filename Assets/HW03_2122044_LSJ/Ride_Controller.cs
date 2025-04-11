using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ride_Controller : MonoBehaviour
{
    public Vehicle_Animator_Controller vehicle;
    public GameObject player;

    private bool isRiding = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Vehicle" && !isRiding)
        {
            print("ride");
            isRiding = true;

            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;

            int state = vehicle.animator.GetInteger("ridestat");

            if (state == 3) 
            {
                vehicle.PlayToRoom1();
            }
            else if (state == 4) 
            {
                vehicle.PlayToRoom2();
            }

            else if (state == 5 || state == 6)
            {
                vehicle.Resume();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle" && isRiding)
        {
            isRiding = false;
            transform.SetParent(null);

            vehicle.Pause();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFloor : MonoBehaviour
{
    public bool isOnFloor1 = false;
    public bool isOnFloor2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Floor")
        {
            isOnFloor1 = true;
        }
        else if (other.name == "Floor2")
        {
            isOnFloor2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Floor")
        {
            isOnFloor1 = false;
        }
        else if (other.name == "Floor2")
        {
            isOnFloor2 = false;
        }
    } 

}

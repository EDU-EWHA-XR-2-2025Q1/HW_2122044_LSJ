using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door1 : MonoBehaviour
{
    public Animator Animator;
    public GameObject player;
    private OnFloor onFloorScript;

    void Start()
    {
        onFloorScript = player.GetComponent<OnFloor>();
    }

    private void OnTriggerEnter(Collider other)     
    {
        if ((Animator.GetInteger("status2") == 4 || Animator.GetInteger("status2")==5) && onFloorScript.isOnFloor2==false && other.name=="DoorController2")
        {

            Animator.SetInteger("status2", 1);
           
        }
        

        else if (Animator.GetInteger("status2") == 2 && onFloorScript.isOnFloor2 == true && other.name == "DoorController2")
        {
            Animator.SetInteger("status2", 3);
        }

    }
    private void OnTriggerExit(Collider other)     
    {
        print("exit");
        print(onFloorScript.isOnFloor2);
        if (Animator.GetInteger("status2") == 1 && onFloorScript.isOnFloor2 == true && other.name == "DoorController2")
        {
            print("close");
            
            Animator.SetInteger("status2", 2);

        }
        else if (Animator.GetInteger("status2") == 3 && onFloorScript.isOnFloor2 == false)
        {
            Animator.SetInteger("status2", 4);
        }

    }
}

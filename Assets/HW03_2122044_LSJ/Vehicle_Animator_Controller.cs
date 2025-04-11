using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_Animator_Controller : MonoBehaviour
{
    public Animator animator;
    public int direction = 0;

    public void PlayToRoom2()
    {

        direction = 1;
        animator.SetInteger("ridestat", 1);
        animator.speed = 1;
    }

    public void PlayToRoom1()
    {
        direction = 2;
        animator.SetInteger("ridestat", 2);
        animator.speed = 1;
    }

    public void Pause()
    {
        animator.speed = 0;

        if (direction == 1)
        {
            animator.SetInteger("ridestat", 5); 
            print("����");
        }
            
        else if (direction == 2)
            animator.SetInteger("ridestat", 6); 
    }

    public void Resume()
    {
        animator.speed = 1;

        int status = animator.GetInteger("ridestat");

        if (status == 5)
            animator.SetInteger("ridestat", 1); 
        else if (status == 6)
            animator.SetInteger("ridestat", 2); 
    }
    void Update()
    {
        float currentPos = transform.position.z;
        int ridestat = animator.GetInteger("ridestat");

        if ((ridestat == 1 || ridestat == 5) && Mathf.Abs(currentPos - (-22.3f)) < 0.5f)
        {
            animator.SetInteger("ridestat", 3);
            animator.speed = 0;
            Debug.Log("Room2 ridestat = 3");
        }

        else if ((ridestat == 2 || ridestat == 6) && Mathf.Abs(currentPos - 22.9f) < 0.5f)
        {
            animator.SetInteger("ridestat", 4);
            animator.speed = 0;
            Debug.Log("Room1 ridestat = 4");
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Swordsman : Player
{
    public Hand LeftHand;
    public Hand RightHand;
    public Foot LeftFoot;
    public Foot RightFoot;
    public Body MainBody;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LeftPunch();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RightPunch();
        }

       transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void Movebackward()
    {
        transform.Translate(Vector3.back * Time.deltaTime);
    }

    public void LeftPunch()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("LeftPunch");
    }

    public void RightPunch()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("RightPunch");
    }


}

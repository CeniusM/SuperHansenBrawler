using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public float Hp;
public float Dmg;
public float AtcSpeed;
public float Speed;
 */

public class Ninja : Player
{
    public float Hp;
    public Body Body;
    public Hand LeftHand;
    public Hand RightHand;
    public Foot LeftFoot;
    public Foot RightFoot;

    // Field to store the speed of the Ninja
    public float Speed;

    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Punch();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Kick();
        }
    }

    // Method to move the Ninja forward
    public void MoveForward()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("MoveForward");
    }

    // Method to move the Ninja backward
    public void MoveBackward()
    {
        transform.Translate(Vector3.back * Time.deltaTime * Speed);
    }

    // Method to make the Ninja perform an attack
    public void Punch()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("Punch");
    }

    // Method to make the Ninja perform a kick
    public void Kick()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("Kick");
    }


    // Method to make the Ninja take damage
    public void TakeDmg(float damageAmount)
    {
        // Subtract the damageAmount from the Ninja's Hp
        Hp -= damageAmount;

        // Check if the Ninja's Hp has dropped to or below zero
        if (Hp <= 0)
        {
            // Implement logic for what happens when the Ninja's Hp reaches zero or below
        }
    }
}

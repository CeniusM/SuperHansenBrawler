using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the speed as needed

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow keys
        //float verticalInput = Input.GetAxis("Vertical");     // W/S or Up/Down arrow keys

        //Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        //moveDirection.Normalize(); // Ensure that diagonal movement isn't faster

        //// Move the object
        //transform.position += moveDirection * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 360 * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -360 * Time.deltaTime, 0);
        }
    }
}
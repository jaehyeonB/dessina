using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhysicalMove : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float jumpForce = 5f;

    public Rigidbody rb;

    private bool isgrounded;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");


        Vector3 Direction = new Vector3(moveX, 0, moveZ).normalized;

        rb.MovePosition(transform.position + Direction * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isgrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isgrounded = false;
    }
}







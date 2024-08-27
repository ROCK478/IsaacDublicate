using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Vector3 lastDirection = Vector3.zero;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        if (direction != Vector3.zero)
        {
            lastDirection = direction;
            transform.rotation = Quaternion.LookRotation(lastDirection);
        }
        else
        {
            lastDirection = Vector3.zero;
        }
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), rb.velocity.y, Input.GetAxis("Vertical")).normalized * moveSpeed;
    }
}

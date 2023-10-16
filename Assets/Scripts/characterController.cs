using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float jumpForce = 50;
    public bool wantJump;
    public bool isInFloor;
    public float movX, movZ;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            wantJump = true;
        }
    }

    void FixedUpdate()
    {
        Vector3 speed = new Vector3(movX, 0, movZ);
        rb.velocity = speed * 5;

        if (wantJump && isInFloor)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            wantJump = false;
            isInFloor = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            isInFloor = true;
        }
    }
}

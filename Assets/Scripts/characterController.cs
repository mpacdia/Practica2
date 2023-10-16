using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    static characterController current;

    public float movSpeed = 15;
    public float jumpForce = 50;
    public bool wantJump;
    public bool isOnFloor;
    public float movX, movZ;
    Rigidbody rb;

    public int coinManager = 0;

    private void Awake()
    {
        current = this;
    }

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
        rb.velocity = speed * movSpeed;

        if (wantJump && isOnFloor)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            wantJump = false;
            isOnFloor = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            isOnFloor = true;
        }
    }

    public static void addCoin()
    {
        current.coinManager++;
    }
}

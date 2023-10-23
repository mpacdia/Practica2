using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    static characterController current;

    public float movSpeed = 15;
    public float jumpForce = 500;
    public bool wantJump;
    public bool isOnFloor;
    public float movX, movZ;
    Rigidbody rb;

    public int coinManager = 0;

    public GameObject wayPoint;
    public float timer;

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

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0)
        {
            UpdatePosition();
            timer = 0.5f;
        }
    }

    void UpdatePosition()
    {
        wayPoint.transform.position = transform.position;
    }


    void FixedUpdate()
    {
        Vector3 speed = new Vector3(movX* movSpeed, rb.velocity.y, movZ * movSpeed);
        rb.velocity = speed;

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

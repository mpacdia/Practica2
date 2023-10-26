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

    public float height;

    public int coinManager = 0;

    public GameObject wayPoint;
    public float timer;

    public AudioSource jumpSoundEffect;

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
        height = transform.position.y;

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

        if (height < -1)
        {
            height = 3;
        }
        else if (height >= -1)
        {
            height = transform.position.y;
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
            jumpSoundEffect.Play();
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

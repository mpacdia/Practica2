using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

    public float enemySpeed = 8;
    private GameObject wayPoint;
    public Vector3 wayPointPosition;

    // Start is called before the first frame update
    void Start()
    {
        wayPoint = GameObject.Find("wayPoint");
    }

    // Update is called once per frame
    void Update()
    {
        wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, wayPointPosition, enemySpeed * Time.deltaTime);
    }
}

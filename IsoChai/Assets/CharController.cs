using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]
    float moveSpeed = 3f;
    public Joystick joystick;
    Vector3 forward, right;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKey)
            Move();
	}

    void Move()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * joystick.Horizontal;
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * joystick.Vertical;

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;

        //rb.MovePosition(rightMovement+upMovement);
    }
}

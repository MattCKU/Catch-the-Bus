﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2Controller : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 3f;
    public Joystick joystick;
    Vector3 forward, right;

	// Use this for initialization
	void Start ()
    {
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
        
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
       Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Random.Range(-5.0f, 0.0f);
       Vector3 upMovement = forward * moveSpeed * Time.deltaTime * -Input.GetAxis("VerticalKey") * Random.Range(-5.0f, 2.0f);

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public Movement Movement;
    
	private void Start ()
    {
        Movement = new Movement(Speed);
	}
	
	private void Update ()
    {
        transform.position += Movement.Calculate(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), Time.deltaTime);
	}
}

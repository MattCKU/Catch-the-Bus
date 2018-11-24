using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_cat : MonoBehaviour {

	Rigidbody rb;

	[SerializeField] 
	private Vector3 movementDir = new Vector3(-60,0,-30);
	[SerializeField] 
	private float speed = 5f;
	// Use this for initialization
	void Start () {
		transform.eulerAngles = new Vector3(90,320,0);
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.MovePosition(transform.position + movementDir.normalized*speed*Time.deltaTime);
		//transform.Translate(movementDir.normalized*speed*Time.deltaTime);
		
		//transform.Rotate(0,240,0);
	}
}
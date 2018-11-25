using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_bus : MonoBehaviour {

	Rigidbody rb;
	GameObject self;
	[SerializeField]
	private GameObject laneObject;
	[SerializeField] 
	private Vector3 movementDir = new Vector3(-60,0,-30);
	[SerializeField] 
	private float speed = 5f;
	// Use this for initialization
	void Start (){
		transform.eulerAngles = new Vector3(0,328.9f,0);
		rb = GetComponent<Rigidbody>();
		self=GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = Vector3.MoveTowards(transform.position, laneObject.transform.position, speed*Time.deltaTime);
		rb.MovePosition(movement);
		//rb.MovePosition(transform.position + movementDir.normalized*speed*Time.deltaTime);
		//transform.Translate(movementDir.normalized*speed*Time.deltaTime);
		
		//transform.Rotate(0,240,0);
	}

}
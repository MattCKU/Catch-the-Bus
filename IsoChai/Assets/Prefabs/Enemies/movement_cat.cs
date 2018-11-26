using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_cat : MonoBehaviour {

	Rigidbody rb;
	GameObject self;
	[SerializeField]
	private GameObject laneObject;
	[SerializeField] 
	private Vector3 movementDir = new Vector3(-60,0,-30);
	[SerializeField] 
	private float speed = 5f;
	// Use this for initialization
	void Start () {
		transform.eulerAngles = new Vector3(90,328.9f,0);
		rb = GetComponent<Rigidbody>();
		self=GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.MovePosition(transform.position + movementDir.normalized*speed*Time.deltaTime);
	}
	/*
	@pre calls on collsiion enter
	@post delets object if coliding with object
	@param collision = object that is collided with
 	*/
	void onCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Wall"){
			Destroy(self);
		}
	}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*
	@pre calls on collision triger enter
	@post delets object if object is enemy
	@param col = object that is collided with
 	*/
	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Enemy")
		{

			Destroy(col.gameObject);
		}
	}
 }


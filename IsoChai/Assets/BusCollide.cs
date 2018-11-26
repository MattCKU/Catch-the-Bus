using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BusCollide : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*
	@pre calls on trigger
	@post win if player collides with bus
	@param other = object colided with
 	*/
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Entered.");
		if(other.gameObject.tag=="Player"){
			SceneManager.LoadScene("finalwin");
		}
		
		//player.transform.position = new Vector3(0, y: 2, z: 0	);
	}
}

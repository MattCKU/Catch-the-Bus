using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Zone : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("On top sidewalk. Slowing Down.");

	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log("Leaving the top sidewalk. Speeding up.");
	}
}

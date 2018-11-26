using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Zone : MonoBehaviour {

	public GameObject player;
	[SerializeField]
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("On top sidewalk. Slowing Down.");
			player.GetComponent<CharController>().setMovementSpeed(4);
		}
	
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("Leaving the top sidewalk. Speeding up.");
			player.GetComponent<CharController>().setMovementSpeed(9);
		}
		
	}
}

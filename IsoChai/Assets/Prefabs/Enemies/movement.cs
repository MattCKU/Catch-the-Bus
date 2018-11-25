using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	Rigidbody rb;
	[SerializeField]
	private GameObject laneObject;
	[SerializeField] 
	private float speed = 5f;
	// Use this for initialization
	void Start () {
		//transform.eulerAngles = new Vector3(0,240,0);
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = Vector3.MoveTowards(transform.position, laneObject.transform.position, speed*Time.deltaTime);
		rb.MovePosition(movement);
	}
    public void setLaneObject(GameObject obj){
        laneObject=obj;
    }
}

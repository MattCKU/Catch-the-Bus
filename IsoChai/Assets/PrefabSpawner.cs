using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour {

	private float nextSpawnTime;

	[SerializeField]
	private GameObject spawnObject;
	[SerializeField]
	private float spawnDelay=10f;
	[SerializeField]
	private float rand_variance = 0.0f;
	[SerializeField]
	private GameObject laneObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= nextSpawnTime){
			Spawn();
		}
	}
	private void Spawn(){
		nextSpawnTime = Time.time + spawnDelay + Random.Range(-1*rand_variance,rand_variance);
		var obj = Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
		obj.GetComponent<movement>().setLaneObject(laneObject);
	
		
	}

}


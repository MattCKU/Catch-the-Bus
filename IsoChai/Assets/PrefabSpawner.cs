using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour {

	private float nextSpawnTime;

	[SerializeField]
	private GameObject spawnObject;
	[SerializeField]
	private float spawnDelay=10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(shouldSpawn()){
			Spawn();
		}
	}
	private void Spawn(){
		nextSpawnTime = Time.time + spawnDelay;
		Instantiate(spawnObject, transform.position, transform.rotation);
	}
	private bool shouldSpawn(){
		return Time.time >= nextSpawnTime;
	}

}


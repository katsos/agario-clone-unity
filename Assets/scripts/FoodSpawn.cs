using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour {

	public GameObject food;
	public float speed;

	void Start () {
		// InvokeRepeating("Spawn", 0, speed);
		Spawn();
	}
	
	void Spawn () {
		Vector3 position = new Vector3(4, 4, 0);
		Quaternion noRotation = Quaternion.identity;
		Instantiate(food, position, noRotation);
	}
}

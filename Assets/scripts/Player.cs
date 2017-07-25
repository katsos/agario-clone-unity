using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float startingSize;

	void Awake() {
		transform.localScale = new Vector3(startingSize, startingSize, 0);
	}

}

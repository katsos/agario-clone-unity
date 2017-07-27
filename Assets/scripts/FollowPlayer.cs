using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public float smoothSpeed;
	float cameraZposition;
	GameObject player;
	Vector3 playerPosition;
	void Awake() {
		player = GameObject.Find("player");
		cameraZposition = transform.position.z;
	}
	
	void LateUpdate() {
		followPlayer ();
	}

	/**
	 * Follow player on x and y axis
	 */
	void followPlayer() {
		Vector3 playerPosition = player.transform.position;
		Vector3 whereToGo = new Vector3(playerPosition.x, playerPosition.y, cameraZposition);
		transform.position = Vector3.Lerp (transform.position, whereToGo, smoothSpeed);
	}
}
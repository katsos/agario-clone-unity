using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float startingSize;
	public float startingMovementDelay;
	public float speed;

	void Awake() {
		transform.localScale = new Vector3(startingSize, startingSize, 0);
	}
	void Update() {
		if (isMouseInsideViewport()) Move();
	}

	void Move() {
		if (Time.time < startingMovementDelay) return;

		Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		targetPosition.z = 0;

		transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
	}

	bool isMouseInsideViewport() {
		Rect screen = new Rect(0, 0, Screen.width, Screen.height);
		return screen.Contains(Input.mousePosition);
	}
}

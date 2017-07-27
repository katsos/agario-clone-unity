using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float startingSize;
	public float startingMovementDelay;
	public float speed;
	public float sizeAugmenter;

	void Awake() {
		transform.localScale = new Vector3(startingSize, startingSize, 0);
		gameObject.GetComponent<SpriteRenderer>().color = getRandomColor();
	}
	
	void Update() {
		if (isMouseInsideViewport()) Move();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "food") {
			getBigger();
			Destroy(other.gameObject);
		}
	}

	/* Custom Functions */
	void getBigger() {
		transform.localScale += new Vector3(sizeAugmenter, sizeAugmenter, 0);
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

	Color getRandomColor() {
		return new Color(Random.value,Random.value, Random.value);
	}

}

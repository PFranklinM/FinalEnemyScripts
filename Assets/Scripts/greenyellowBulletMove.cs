using UnityEngine;
using System.Collections;

public class greenyellowBulletMove : MonoBehaviour {

	public GameObject enemy;
	public GameObject player;

	bool playerOnLeft = true;

	// Use this for initialization
	void Start () {

		enemy = GameObject.Find("enemy");

		player = GameObject.Find("player");

		if (player.transform.position.x < enemy.transform.position.x) {
			playerOnLeft = true;
		}

		if (player.transform.position.x > enemy.transform.position.x) {
			playerOnLeft = false;
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 bulletPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		Vector3 bulletSize = new Vector3(transform.localScale.x, 
			transform.localScale.y, 
			transform.localScale.z);

		if (playerOnLeft == true) {
			bulletPos.x -= 15f * Time.deltaTime;
		}

		if (playerOnLeft == false) {
			bulletPos.x += 15f * Time.deltaTime;
		}

		if (transform.localScale.x < 0.9f && transform.localScale.y < 0.9f) {
			bulletSize.x += 0.04f;
			bulletSize.y += 0.04f;
		}

		if (Vector3.Distance (enemy.transform.position, transform.position) > 10f) {
			Destroy (this.gameObject);
		}

		transform.position = bulletPos;

		transform.localScale = bulletSize;
	
	}
}

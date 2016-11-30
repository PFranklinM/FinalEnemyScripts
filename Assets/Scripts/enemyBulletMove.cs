using UnityEngine;
using System.Collections;

public class enemyBulletMove : MonoBehaviour {

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

		if (playerOnLeft == true) {
			bulletPos.x -= 15f * Time.deltaTime;
		}

		if (playerOnLeft == false) {
			bulletPos.x += 15f * Time.deltaTime;
		}

		if (Vector3.Distance (enemy.transform.position, transform.position) > 10f) {
			Destroy (this.gameObject);
		}

		transform.position = bulletPos;
	
	}
}

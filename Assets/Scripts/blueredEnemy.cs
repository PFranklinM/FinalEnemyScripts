using UnityEngine;
using System.Collections;

public class blueredEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	float moveCounter = 0f;

	float moveAmount = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 enemyPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (Vector3.Distance (enemy.transform.position, player.transform.position) < 10f) {

			if (enemyPos.x < player.transform.position.x) {
				enemyPos.x += 3f * Time.deltaTime;
			}

			if (enemyPos.x > player.transform.position.x) {
				enemyPos.x -= 3f * Time.deltaTime;
			}

			enemyPos.y += moveAmount * Time.deltaTime;

			moveCounter += Time.deltaTime;

			if(moveCounter >= 1) {
				moveAmount = -moveAmount;
				moveCounter = 0;
			}

			if (enemy.transform.position.x - player.transform.position.x < 1) {
				enemyPos.y -= 3f * Time.deltaTime;
			}
		}

		transform.position = enemyPos;
	}
}

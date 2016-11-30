using UnityEngine;
using System.Collections;

public class greenEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 enemyPos = new Vector3 (transform.position.x,
			                   transform.position.y,
			                   transform.position.z);

		Vector3 enemySize = new Vector3(transform.localScale.x, 
										transform.localScale.y, 
										transform.localScale.z);

		if (Vector3.Distance (enemy.transform.position, player.transform.position) < 10f) {

			if (enemyPos.x < player.transform.position.x) {
				enemyPos.x += 0.5f * Time.deltaTime;
			}

			if (enemyPos.x > player.transform.position.x) {
				enemyPos.x -= 0.5f * Time.deltaTime;
			}

			if (transform.localScale.x < 5 && transform.localScale.y < 5) {
				enemySize.x += 0.01f;
				enemySize.y += 0.01f;
			}
		}

		transform.position = enemyPos;

		transform.localScale = enemySize;
	
	}
}

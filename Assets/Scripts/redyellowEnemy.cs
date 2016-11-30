using UnityEngine;
using System.Collections;

public class redyellowEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	public GameObject enemyBullet;

	float ROF = 0f;

	float shotDelay = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (enemy.transform.position, player.transform.position) < 10f) {
			transform.position = Vector3.Lerp(transform.position, player.transform.position, 0.05f);

			if (Time.time > ROF) {

				shotDelay = 0.5f;

				ROF = Time.time + shotDelay;

				GameObject bulletClone = (GameObject)Instantiate (enemyBullet);

				Physics.IgnoreCollision (bulletClone.GetComponent<Collider> (), enemy.GetComponent<Collider> ());

				bulletClone.transform.position = enemy.transform.position;
			}
		}
	
	}
}

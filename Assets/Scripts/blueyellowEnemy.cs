using UnityEngine;
using System.Collections;

public class blueyellowEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	public GameObject enemyBullet;

	Rigidbody rb;

	float jumpCounter = 0f;

	bool touchingGround;

	float ROF = 0f;

	float shotDelay = 0f;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();

		touchingGround = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (enemy.transform.position, player.transform.position) < 10f) {

			if (player.transform.position.x < enemy.transform.position.x && touchingGround == true) {

				jumpCounter += Time.deltaTime;

				if (jumpCounter > 1f) {
					rb.velocity = new Vector3 (-2, 10, 0);
					touchingGround = false;
					jumpCounter = 0.0f;
				}
			}

			if (player.transform.position.x > enemy.transform.position.x && touchingGround == true) {

				jumpCounter += Time.deltaTime;

				if (jumpCounter > 1f) {
					rb.velocity = new Vector3 (2, 10, 0);
					touchingGround = false;
					jumpCounter = 0.0f;
				}
			}

			if (touchingGround == false) {

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

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "ground") {
			touchingGround = true;
		}
	}
}

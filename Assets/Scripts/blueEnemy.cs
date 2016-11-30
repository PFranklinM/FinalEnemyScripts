using UnityEngine;
using System.Collections;

public class blueEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	Rigidbody rb;

	float jumpCounter = 0f;

	bool touchingGround;

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

				if (jumpCounter > 1.5f) {
					rb.velocity = new Vector3 (-1, 10, 0);
					touchingGround = false;
					jumpCounter = 0.0f;
				}
			}

			if (player.transform.position.x > enemy.transform.position.x && touchingGround == true) {

				jumpCounter += Time.deltaTime;

				if (jumpCounter > 1.5f) {
					rb.velocity = new Vector3 (1, 10, 0);
					touchingGround = false;
					jumpCounter = 0.0f;
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

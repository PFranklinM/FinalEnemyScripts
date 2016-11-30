using UnityEngine;
using System.Collections;

public class greenredEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 enemySize = new Vector3(transform.localScale.x, 
			transform.localScale.y, 
			transform.localScale.z);

		if (Vector3.Distance (enemy.transform.position, player.transform.position) < 10f) {

			transform.position = Vector3.Lerp(transform.position, player.transform.position, 0.05f);

			if (transform.localScale.x < 5 && transform.localScale.y < 5) {
				enemySize.x += 0.01f;
				enemySize.y += 0.01f;
			}
		}

		transform.localScale = enemySize;
	
	}
}

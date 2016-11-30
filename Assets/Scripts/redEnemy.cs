using UnityEngine;
using System.Collections;

public class redEnemy : MonoBehaviour {

	public GameObject player;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (enemy.transform.position, player.transform.position) < 10f) {
			transform.position = Vector3.Lerp(transform.position, player.transform.position, 0.05f);
		}
	
	}
}

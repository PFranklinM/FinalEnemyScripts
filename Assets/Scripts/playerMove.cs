using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 playerPos = new Vector3 (transform.position.x,
			                    transform.position.y,
			                    transform.position.z);

		if(Input.GetKey(KeyCode.A)){
			playerPos.x -= 5 * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.D)){
			playerPos.x += 5 * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.W)){
			playerPos.y += 15 * Time.deltaTime;
		}

		transform.position = playerPos;
	
	}
}

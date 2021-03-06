using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour {

	public int movementSpeed = 20;
	public int chargeSpeed = 50;
	public int rotateSpeed = 20;
	public int flightSpeed = 50;


	public Transform spawnLocation;
	public GameObject cannonballPrefab;
	public Transform CannonPivot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);

		//left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
		}

		//right
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
		}
			
		//charge
		bool shiftHold = Input.GetKey (KeyCode.RightShift);
		bool moved = false;

		if (Input.GetKey(KeyCode.RightShift)) {
			transform.Translate (Vector3.forward * chargeSpeed * Time.deltaTime);
			moved = true;
		}
		//fly up
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * flightSpeed * Time.deltaTime);
		}
		//fly down
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * flightSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.Space))
		{
			Instantiate (cannonballPrefab, spawnLocation.position, spawnLocation.rotation);
		}


	}
		
}

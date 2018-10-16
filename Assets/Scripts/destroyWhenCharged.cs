using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyWhenCharged : MonoBehaviour {

	public AudioClip enemyDestroyed;
	static public float enemiesDestroyed;
	public BoxCollider enemyHitBox;
	public GameObject collectibleToSpawn;
	public Transform collectibleSpawnLocation;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider player){
		if (Input.GetKey (KeyCode.RightShift)) {
			GetComponent<BoxCollider> ().enabled = false;
			GetComponent<AudioSource> ().Play ();
			GetComponent<Renderer> ().enabled = false;
			Destroy(gameObject, enemyDestroyed.length);
			enemiesDestroyed++;
			Instantiate (collectibleToSpawn, collectibleSpawnLocation.position, collectibleSpawnLocation.rotation);
			//print (enemiesDestroyed);
		}

	}
}

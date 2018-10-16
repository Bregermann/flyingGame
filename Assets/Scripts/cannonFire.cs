using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonFire : MonoBehaviour {
	public Transform spawnLocation;
	public GameObject cannonballPrefab;
	public Transform CannonPivot;

	public AudioClip enemyDestroyed;
	static public float enemiesDestroyed;
	public BoxCollider enemyHitBox;
	public GameObject collectibleToSpawn;
	public Transform collectibleSpawnLocation;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate (cannonballPrefab, spawnLocation.position, spawnLocation.rotation);
		}

	}
	void OnTriggerEnter(Collider enemy){
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


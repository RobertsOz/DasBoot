using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasentSpawner : MonoBehaviour {

    public GameObject LowLevelPeasent;
    public GameObject MidLevelPeasent;
    public GameObject HighLevelPeasent;
    public float SpawnRateTime = 5f;
    public bool SpawnerSwitch = true;

	private float SpawnDelay = 2f;
    
	Vector3 SpawnerPosition;
    
	void Start ()
    {
        SpawnerPosition = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        InvokeRepeating("Spawn", SpawnDelay, SpawnRateTime);
		SpawnDelay -= Time.deltaTime;
		SpawnDelay = Mathf.Clamp (SpawnDelay, 0.1f, 2f);

    }

    void Spawn()
    {
		Instantiate(LowLevelPeasent, SpawnerPosition, Quaternion.identity);
    }

    void Update ()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasentSpawner : MonoBehaviour {

    public GameObject LowLevelPeasent;
    public GameObject MidLevelPeasent;
    public GameObject HighLevelPeasent;
    public float SpawnRateTime = 5f;
    public bool SpawnerSwitch = true;
    Vector3 SpawnerPosition;
    
	void Start ()
    {
        SpawnerPosition = new Vector3(this.transform.position.x, this.transform.position.x, 0);

        InvokeRepeating("Spawn", 2f, SpawnRateTime);
    }

    void Spawn()
    {
        Instantiate(LowLevelPeasent, SpawnerPosition, Quaternion.identity);
    }

    void Update ()
    {

    }
}

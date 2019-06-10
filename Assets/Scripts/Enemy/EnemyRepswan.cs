using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRepswan : MonoBehaviour
{

    public GameObject enemy; // The enemy prefab to be spawned
    public float spawnTime = 3f;   // How long between each spawn
    public Transform[] spawnPoints; // An array of the spawn points this enemy can be spawn from
    // Use this for initialization
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {


        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation
        Instantiate(enemy, transform.position + new Vector3(Random.Range(-7.5f, 7.5f), 1f, Random.Range(-7.5f, 7.5f)), Quaternion.identity);
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] projectilePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectiles", 1, 1);
    }

    public void SpawnProjectiles()
    {
        int randProjectile = Random.Range(0, projectilePrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(projectilePrefabs[randProjectile], spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}

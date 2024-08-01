using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawner : MonoBehaviour
{
    public GameObject ufoPrefab;
    public float spawnInterval = 2f;
    public float minSpeed = 2f;
    public float maxSpeed = 5f;
    public float xMin;
    public float xMax;

    void Start()
    {
        InvokeRepeating("SpawnUFO", spawnInterval, spawnInterval);
    }

    void SpawnUFO()
    {
        float spawnX = Random.Range(xMin, xMax);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0);
        GameObject ufo = Instantiate(ufoPrefab, spawnPosition, Quaternion.identity);
        ufo.GetComponent<UFO>().speed = Random.Range(minSpeed, maxSpeed);
    }
}

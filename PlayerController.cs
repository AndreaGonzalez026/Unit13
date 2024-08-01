using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform laserSpawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
        }
    }

    void ShootLaser()
    {
        Instantiate(laserPrefab, laserSpawnPoint.position, Quaternion.identity);
    }
}

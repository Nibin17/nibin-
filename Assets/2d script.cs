using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game2D : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float BulletSpeed = 5;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            Bullet.GetComponent<Rigidbody2D>().velocity = BulletSpawnPoint.right * BulletSpeed;
        }
    }
}
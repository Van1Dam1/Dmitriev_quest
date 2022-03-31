using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform target;

    private float step = 5f;
    private float nextShot;

    private void Update ()
    {
        if (!target) { return; }

        if (Time.time > nextShot)
        {
            return;
        }

        nextShot = Time.time + step;

        Shoot();
    }
    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}

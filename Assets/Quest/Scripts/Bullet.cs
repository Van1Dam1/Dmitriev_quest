using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    private void Awake()
    {
        Destroy(gameObject, 1f);
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
}

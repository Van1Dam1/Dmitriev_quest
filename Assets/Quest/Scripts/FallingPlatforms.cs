using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatforms : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Invoke("FallPlatform", 3f);
            Destroy(gameObject, 2f);
        }
    }
    void FallPlatform()
    {
        rb.isKinematic = false;
    }
}

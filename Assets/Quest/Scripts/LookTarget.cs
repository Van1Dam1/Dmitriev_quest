using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float rotationSpeed = 3f;

    void FixedUpdate()
    {
        if (!target) { return; }

        var direction = target.position - transform.position;
        var step = Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.fixedDeltaTime, 0f );

        transform.rotation = Quaternion.LookRotation(step);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Movement : MonoBehaviour
{
    public float turnSpeed = 20f;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Vector3 direction;
    Quaternion m_Rotation = Quaternion.identity;

    void Start()
    {
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction.Set(horizontal, 0f, vertical);
        direction.Normalize();

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool Running = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool("Running", Running);
    }
    void FixedUpdate()
    {
        transform.position += direction * Time.fixedDeltaTime;
        m_Rotation = Quaternion.LookRotation(direction);
    }
    void OnAnimatorMove()
    {
        m_Rigidbody.MovePosition (m_Rigidbody.position + direction * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation (m_Rotation);
    }
}
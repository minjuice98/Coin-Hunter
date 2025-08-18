using System;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.linearVelocity = transform.up * -speed;
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                Debug.Log("Do it");
                playerController.Die();
                Destroy(gameObject);
                
            }
        }
    }
}
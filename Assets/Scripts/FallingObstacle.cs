using System;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public float speed = 15f;

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime*4;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>(); //컴포넌트 가져오기
            if (playerController != null) //컴포넌트 가져오기 성공했다면
            {
                Debug.Log("Do it");
                playerController.Die();
                Destroy(gameObject);
                
            }
        }
    }
}
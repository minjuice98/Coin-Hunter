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
            PlayerController playerController = other.GetComponent<PlayerController>(); //������Ʈ ��������
            if (playerController != null) //������Ʈ �������� �����ߴٸ�
            {
                Debug.Log("Do it");
                playerController.Die();
                Destroy(gameObject);
                
            }
        }
    }
}
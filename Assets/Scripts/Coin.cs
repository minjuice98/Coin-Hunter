using UnityEngine;

public class Coin : MonoBehaviour 
{

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController=other.GetComponent<PlayerController>();
            GameManager gameManager = FindAnyObjectByType<GameManager>();
            if (playerController != null)
            {
                gameManager.coinCount++;
                Destroy(gameObject);
            }
        }
    }
}

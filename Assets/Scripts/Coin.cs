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
            if (playerController != null)
            {
                Destroy(gameObject);
            }
        }
    }
}

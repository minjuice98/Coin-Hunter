using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;// rigidbody ������Ʈ
    public float speed = 8f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {//rigidbody ������Ʈ getcomponent�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed=xInput*speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity= new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;
    }
    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindFirstObjectByType<GameManager>();
        gameManager.EndGame();
    }
}

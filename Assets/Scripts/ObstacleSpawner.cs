using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{//
    public GameObject ObstaclePrefab;
    private Transform target;
    private float spawnRate = 1f;
    private Vector3 spawnObPositionMin = new Vector3(-4f, 10f, -4f);
    private Vector3 spawnObPositionMax = new Vector3(4f, 15f, 4f);

    private float timeAfterSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeAfterSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            float randX = Random.Range(spawnObPositionMin.x, spawnObPositionMax.x);
            float randY = Random.Range(spawnObPositionMin.y, spawnObPositionMax.y);
            float randZ = Random.Range(spawnObPositionMin.z, spawnObPositionMax.z);

            Vector3 spawnPos = new Vector3(randX, randY, randZ);

            //원본, 위치, 회전
            GameObject Coin = Instantiate(ObstaclePrefab);
            Coin.transform.position = spawnPos;
        }

    }
}

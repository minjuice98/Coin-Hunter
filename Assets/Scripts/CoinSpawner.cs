using UnityEngine;

public class CoinSpawner : MonoBehaviour
{//원본, 랜덤 위치, 시간 간격
    public GameObject CoinPrefab;
    public float spawnRate = 1f;
    public Vector3 spawnPositionMin = new Vector3(-4f, 1f, -4f);
    public Vector3 spawnPositionMax = new Vector3(4f, 1f, 4f);

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

            float randX = Random.Range(spawnPositionMin.x, spawnPositionMax.x);
            float randY = Random.Range(spawnPositionMin.y, spawnPositionMax.y);
            float randZ = Random.Range(spawnPositionMin.z, spawnPositionMax.z);

            Vector3 spawnPos = new Vector3(randX, randY, randZ);

            //원본, 위치, 회전
            GameObject Coin = Instantiate(CoinPrefab);
            Coin.transform.position = spawnPos;
        }
        
    }
}

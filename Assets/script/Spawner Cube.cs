using UnityEngine;

public class SpawnerCube : MonoBehaviour
{
    public GameObject posionPrefabs;

    [Header("스폰 타이밍 설정")]
    public float minSpawnInterval = 0.5f;
    public float maxSpawnInterval = 2.0f;

    public float timer = 0.0f;
    public float nextSpawnTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNextSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;

        if (timer > nextSpawnTime)
        {
            SpawnObject();
            timer = 0.0f;
            SetNextSpawnTime();
        }
    }


    void SpawnObject()
    {
        Transform spawnTransform = transform;
        Instantiate(posionPrefabs, spawnTransform.position, spawnTransform.rotation);
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnInterval, maxSpawnInterval);
    }


}

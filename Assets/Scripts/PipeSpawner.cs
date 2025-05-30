using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;

    public float spawnDelay = 3.5f;
    private float lastSpawn = 0;

    public float heightOffset = 3;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if (lastSpawn < spawnDelay)
        {
            lastSpawn += Time.deltaTime;
            return;
        }
        Spawn();
        lastSpawn = 0;
    }

    void Spawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0);

        Instantiate(pipe, spawnPosition, transform.rotation);
    }
}

using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnItem), 1f, spawnRate);
    }

    void SpawnItem()
    {
        if (GameManager.Instance.isGameOver) return;

        Vector3 pos = new Vector3(
            Random.Range(-8f, 8f),
            1f,
            Random.Range(-8f, 8f)
        );

        Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)], pos, Quaternion.identity);
    }
}
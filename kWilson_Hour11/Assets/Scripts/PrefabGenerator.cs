using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    
    Vector3 spawnPoint = new Vector3(-1f, 2f, -5f);

    void Start()
    {
        
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = spawnPoint + new Vector3(i * 3f, 0f, 0f);

            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab, spawnPoint, Quaternion.identity);
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
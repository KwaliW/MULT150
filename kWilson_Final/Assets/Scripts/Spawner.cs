using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;

    public float spawnCycle = 0.5f;

    GameManager manager;
    float elapsedTime;

    bool spawnPowerup = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnCycle)
        {
            GameObject temp;

            if (spawnPowerup)
            {
                temp = Instantiate(powerupPrefab);
            }
            else
            {
                temp = Instantiate(obstaclePrefab);
            }

            Vector3 position = temp.transform.position;

            position.x = Random.Range(-3f, 3f);

            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();

            col.manager = manager;

            elapsedTime = 0;

            spawnPowerup = !spawnPowerup;
        }
    }
}
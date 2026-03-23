using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        Debug.Log(health);

        // Loop while player is alive
        while (health > 0)
        {
            health -= poisonDamage;
            Debug.Log(health);
        }

        // Check if player is dead
        if (health <= 0)
        {
            Debug.Log("Player has been unalived!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
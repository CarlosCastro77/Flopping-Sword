using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacles;

    float cooldown = 1;

    ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    void Update()
    {
        ProcessCooldown();
    }

    void ProcessCooldown()
    {
        if (cooldown <= 0)
        {
            SpawnObstacle();
            cooldown = 3 - (scoreManager.score / 10);
        } else
        {
            cooldown -= Time.deltaTime;
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obstacles, new Vector3(5, Random.Range(-3, 3)), Quaternion.identity);
    }
}

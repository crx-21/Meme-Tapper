using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawner : MonoBehaviour
{
    public GameObject prefab;
    public GameZone gameZone;

    public float spawnInterval = 1f;
    public int maxObjects = 20;

    private float timer;
    private int currentCount;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval && currentCount < maxObjects)
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        Vector2 spawnPos = gameZone.GetRandomPosition();
        Instantiate(prefab, spawnPos, Quaternion.identity);
        currentCount++;
    }

    public void ObjectDestroyed()
    {
        currentCount--;
    }
}

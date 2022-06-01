using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    // Update is called once per frame
    public void SpawnObject()
    {
        GameObject toSpawn;
        MeshCollider c = Spawner.GetComponent<MeshCollider>();
        int randomItem = 0;

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];
            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);
            float spawnY = Random.Range
                    (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(toSpawn, spawnPosition, Quaternion.identity);
        }
    }
}

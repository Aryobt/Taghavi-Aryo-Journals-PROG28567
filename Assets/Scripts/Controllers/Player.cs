using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    public float bombTrailSpacing;
    public int numberOfTrailBombs;
    public float inDistance = 1f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombAtOffset (new Vector3(0,1));
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnBombTrail (new Vector3(0,1,0));

        }


    }

    public void SpawnBombAtOffset (Vector3 inOffset)
    {
        Vector3 spawnPosition = transform.position + inOffset;
        Instantiate(bombPrefab, spawnPosition, Quaternion.identity);    
    }

    public void SpawnBombTrail(Vector3 inOffset)
    {
        Vector3 spawnPosition = transform.position - inOffset;
      Instantiate(bombPrefab,spawnPosition, Quaternion.identity);
   }
    public void SpawnBombOnRandomCorner ( Vector3 inOffset)
    {
        Vector3[] directions = new Vector3[]
            {
            new Vector3(-1, 0, 1),
            new Vector3(1, 0, 1),
            new Vector3(-1, 0, -1),
            };
        Vector3 randomDirection = directions[Random.Range(0, directions.Length)];
        Vector3 spawnPos = transform.position + randomDirection.normalized * inDistance;
        Instantiate(bombPrefab, spawnPos, Quaternion.identity);
    }
}

using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    public float bombTrailSpacing;
    public int numberOfTrailBombs;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombAtOffset (new Vector3(0,1));
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
           // bombTrailSpacing (new Vector3(0,1,0));

        }
    }

    private void SpawnBombAtOffset (Vector3 inOffset)
    {
        Vector3 spawnPosition = transform.position + inOffset;
        Instantiate(bombPrefab, spawnPosition, Quaternion.identity);    
    }
}

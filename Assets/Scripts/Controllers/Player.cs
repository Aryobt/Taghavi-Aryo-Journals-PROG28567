using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEngine.InputSystem.HID.HID;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    public float bombTrailSpacing;
    public int numberOfTrailBombs;
    public float inDistance = 1f;
    // public Button moveButton;
    public Transform targetTransform;
    [Range(0f, 2f)] public float ratio = 0.5f;
    public float inMaxRange = 2.5f;
    public Transform other;

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
       // if (moveButton != null)
       // {
           // moveButton.onClick.AddListener(OnButtonClick);
       // }
       if (Input.GetKeyDown(KeyCode.S))
        {
         
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
            new Vector3(-1, 0, 1), new Vector3(1, 0, 1), new Vector3(-1, 0, -1)
            };
        Vector3 randomDirection = directions[Random.Range(0, directions.Length)];
        Vector3 spawnPos = transform.position + randomDirection.normalized * inDistance;
        Instantiate(bombPrefab, spawnPos, Quaternion.identity);
    }
    //void OnButtonClick()
   // {
      //  Debug.Log("Button clicked!");
    //}
     public void WarpToTarget()
    {
    
    }

    public void DetectAsteroids()
    {
        inMaxRange = Vector3.Distance(other.position, transform.position);
        Vector3[] inAsteroids = new Vector3[]{
            new Vector3(-13f, -1f,0f), new Vector3(4f, -2f,0f), new Vector3(11f, 3f, 0f), new Vector3(2f,7f,0f), new Vector3(-6f, -1f, 0f)
        };
       // Debug.DrawLine(Player, new Vector3);
    }
}

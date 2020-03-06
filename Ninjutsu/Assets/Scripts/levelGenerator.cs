using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    private const float player_distance = 20f; 

    [SerializeField] private List<Transform> levelPart_lst; 
    [SerializeField] private Transform levelPart_start; 
    [SerializeField] private GameObject player; 

    private Vector3 lastEndPos;
    private void Awake()
    {
        lastEndPos = levelPart_start.Find("endPos").position; 

        int startSpawnParts = 5;
        for (int i = 0; i <startSpawnParts; i++) 
        {
            spawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, lastEndPos) < player_distance)
        {
            spawnLevelPart();
        }
    }
    private void spawnLevelPart()
    {
        Transform choosenPart = levelPart_lst[Random.Range(0, levelPart_lst.Count)]; 
        Transform lastLvlPartTr = spawnLevelPart(choosenPart, lastEndPos); 
        lastEndPos = lastLvlPartTr.Find("endPos").position; 
    }

    private Transform spawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity); 
        return levelPartTransform; 
    }
   
}

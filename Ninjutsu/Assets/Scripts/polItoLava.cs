using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polItoLava : MonoBehaviour
{
    public GameObject player;

    
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, -25f, 0f); 
    }
}

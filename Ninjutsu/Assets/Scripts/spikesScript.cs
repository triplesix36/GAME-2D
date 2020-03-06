using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesScript : MonoBehaviour
{
    private GameObject game_Menu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject); 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text score;
    public GameObject player;
    public int Playerscore;
    void Update()
    {
        Playerscore = Mathf.RoundToInt(player.transform.position.x); 
        score.text = "Score: " + Playerscore.ToString(); 
    }
}

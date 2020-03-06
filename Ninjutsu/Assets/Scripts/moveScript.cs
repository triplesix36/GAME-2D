using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;

namespace UnityStandardAssets._2D 
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class moveScript : MonoBehaviour
    {
        private PlatformerCharacter2D controller; 

        public float speed = 40f; 
        public bool jump = false; 
        public GameObject game_Menu; 

        void Start()
        {
            controller = GetComponent<PlatformerCharacter2D>(); 
        }

        
        void Update()
        {
            if (Input.GetButtonDown("Jump")) 
            {
                jump = true;
            }
        }
        private void FixedUpdate() 
        {
            controller.Move(speed * Time.deltaTime, false, jump); 
            jump = false;
        }
        private void OnDestroy() 
        {
            game_Menu.SetActive(true); 
        }
    }
}

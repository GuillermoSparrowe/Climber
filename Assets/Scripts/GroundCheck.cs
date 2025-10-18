using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Transform gc;
    public Vector3 offset;
    public static bool isGrounded;
    Collider2D playerCol;

      void Start() {
        playerCol = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
    }
   
    void Update()
    {
        transform.position = gc.position + offset;
    }

      private void OnTriggerEnter2D(Collider2D collisionInfo) {
        if(!(collisionInfo.tag == "Player")){
        isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collisionInfo) {
        if(!(collisionInfo.tag == "Player")){
        isGrounded = false;
        }
    }
}

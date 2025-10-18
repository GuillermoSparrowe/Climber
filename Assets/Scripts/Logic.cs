using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool firstCollision;
    public Vector3 rotationPoint;
    public ShadowConroller shadowCon;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shadowCon = GameObject.FindGameObjectWithTag("shadow").GetComponent<ShadowConroller>();
        firstCollision = true;
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.position += new Vector3(-1,0,0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position += new Vector3(1,0,0);

        }

         if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0,0,1), -90);
            shadowCon.position.Plus();
            shadowCon.changeShadowScale();
        }

        if(Input.GetKey(KeyCode.DownArrow)){
                rb.velocity = new Vector2(rb.velocity.x, -10);
        }
        else rb.velocity = new Vector2(rb.velocity.x, -2);


       
    }

  private void OnCollisionEnter2D() {
      rb.velocity = new Vector2(0,0);
    if(firstCollision){
        this.enabled = false;
        rb.isKinematic = false;
        rb.mass = 40;
        rb.gameObject.tag = "UsedPiece";
         FindObjectOfType<Generator>().NewPiece();
         shadowCon.findNewPiece();
         firstCollision = false;
    }
  }         
}

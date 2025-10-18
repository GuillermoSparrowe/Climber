using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowConroller : MonoBehaviour
{

    public GameObject currentPiece;
    public Position position; // hay 4 posiciones 
 
    void Start()
    {
       position = new Position();
        currentPiece = GameObject.FindGameObjectWithTag("NewPiece");
        changeShadowScale();
    }

  
    void Update()
    {
        this.transform.position = currentPiece.transform.position;
    }
      public void findNewPiece(){
        currentPiece = GameObject.FindGameObjectWithTag("NewPiece");
        position.setN(0);
        changeShadowScale();
    }

    public void changeShadowScale(){
             this.transform.localScale = new Vector3(ShadowX(),this.transform.localScale.y,this.transform.localScale.z);
    }

    private int ShadowX(){
        string name = currentPiece.name;
        int x = 0;
        switch(name){
        case "I(Clone)": x = shadowI();
        break;
        case "J(Clone)":  x = shadowJL();
        break;
        case "L(Clone)":  x = shadowJL();
        break;
        case "O(Clone)":  x = 2;
        break;
        case "S(Clone)":  x = shadowSTZ();
        break;
        case "T(Clone)":  x = shadowSTZ();
        break;
        case "Z(Clone)":  x = shadowSTZ();
        break;
        }
        return x;
    }

    private int shadowI(){
        if (position.getN() % 2 == 0) return 1;
        else return 4;

    }
    private int shadowJL(){
        if (position.getN() % 2 == 0) return 2;
        else return 3;

    }
    private int shadowSTZ(){
        if (position.getN() % 2 == 0) return 3;
        else return 2;

    }
}
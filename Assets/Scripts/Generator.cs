using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   public GameObject[] pieces;
   private int nPiecesCol;
   private int random; // Almacena un numero aleatorio para crear una pieza aleatoria
   private Vector3 spawn; // Para poner el lugar adecuado del spawn de cada ficha
   private GameObject[] count;

    void Start()
    {
        spawn = transform.position;
        NewPiece();
    }

    public void NewPiece(){
        if(nPiecesCol==0)
        createPiece();
        }
        
               
    private void createPiece(){
             random = Random.Range(0,pieces.Length);
        // Coger posicion Y del piece Gnerator que va pegado a la camara y despues cambiar la x segun la pieza para que cuadre todo
        spawn = new Vector3 (0,transform.position.y,0);

        switch (random){
                case 0: spawn += new Vector3 (-5.488049f,0,0); //I
                break;

                case 1: spawn += new Vector3 (-6.00251f,0,0); //J
                break;

                case 2: spawn += new Vector3 (-5.006f,0,0); //L
                break;

                case 3: spawn += new Vector3 (-5.008691f,0,0); //O
                break;

                case 4: spawn += new Vector3 (-5.49f,0,0); //S
                break;

                case 5: spawn += new Vector3 (-5.505f,0,0); //T
                break;

                case 6: spawn += new Vector3 (-5.504f,0,0); //Z
                break;
        }

        Instantiate(pieces[random],spawn,Quaternion.identity);

    }
     private void OnTriggerEnter2D() {
        nPiecesCol++;
   }
     private void OnTriggerExit2D(Collider2D col) {
        nPiecesCol--;
        if(nPiecesCol == 0 && col.tag == "UsedPiece") {
            print("uwu");
            NewPiece();
            }
   }
   

}
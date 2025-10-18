using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
  public int n;
  public Position(){
    n = 0;
  }
   public void Plus(){
        if(n == 3) n = 0;
        else n++;
    }
    public void Minus(){
        if(n == 0) n = 3;
        else n--;
        
    }
    public int getN(){
        return n;
    }
    public void setN(int n){
        this.n = n;
    }
}

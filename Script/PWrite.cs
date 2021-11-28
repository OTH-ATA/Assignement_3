/*Othmane Atanane - Yassir Benabdallah*/
/* Assignement #4 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PWrite : MonoBehaviour{
    public int aa,bb,cc,dd=1;
    public LetsPlay clicked;
    public TextMeshPro P;
    public double counting = 0; 
    void Start(){
        clicked = FindObjectOfType(typeof(LetsPlay)) as LetsPlay;
        counting= 0.021;
    }
    void Update(){   
        CalculateBayesianProbability(clicked.LX, clicked.LY, clicked.gx, clicked.gy);
        P.text =  counting.ToString();
    }
    void CalculateBayesianProbability(int LX, int LY, int ghostx, int ghosty) {
        int Distance=0, DistanceX=0, DistanceY=0;
        counting= clicked.jpp("red", 0);
    }
}
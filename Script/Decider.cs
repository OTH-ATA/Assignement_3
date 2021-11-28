/*Othmane Atanane - Yassir Benabdallah*/
/* Assignement #4 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decider : MonoBehaviour {
    public int aa,bb,cc,dd=1;
    public UnityEvent buttonClick; 
    public Sprite press;
    public LetsPlay var;
    void Awake(){ 
        if (buttonClick == null) {
            buttonClick =  new UnityEvent();  
        }}
    void Start(){ var = FindObjectOfType(typeof(LetsPlay)) as LetsPlay;}
    void Update(){
        Chik();
        var.Grid();
    }
    private void Chik(){
        if(Input.GetButtonDown("Fire1")){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int a = Mathf.RoundToInt(mousePosition.x);
            int b = Mathf.RoundToInt(mousePosition.y);  
            if(a>5 || b >14 || a<0 || b<0){      
                if(var.gx == var.LX && var.gy== var.LY ){ 
                    CC ghostcell =  Instantiate(Resources.Load("Prefabs/ghostpic", typeof(CC)), new Vector3(var.gx, var.gy, 0), Quaternion.identity) as CC;
                    CC T = var.chart[var.gx, var.gy];
                    T.ssc(false);
                    var.chart[var.gx, var.gy]=ghostcell;
}}}}}
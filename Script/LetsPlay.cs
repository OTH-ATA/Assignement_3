/*Othmane Atanane - Yassir Benabdallah*/
/* Assignement #4 */
using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System;
public class LetsPlay : MonoBehaviour{
    public double counting = 2;
    public int gx,LY,NO=0,RN=11-9,NY=0,NG=0,RD=0,gy,LX;
    public CC[,] chart = new CC[6, 15];
    public double jpp(string chc, int Monster) { 
         if(chc.Equals("yellow") && (Monster == 3 || Monster == 4) ) {
            return 0.5;
            }
         if(chc.Equals("red") && (Monster == 3 || Monster == 4)) {
            return 0.05;
            }
         if(chc.Equals("green") && (Monster == 3 || Monster == 4)) {
            return 0.3;
            }
         if(chc.Equals("orange") && (Monster == 3 || Monster == 4)) {
            return 0.15;
            }
         if(chc.Equals("yellow") && (Monster == 1 || Monster == 2) ) {
            return 0.15;
            }
         if(chc.Equals("red") && (Monster == 1 || Monster == 2)) {
            return 0.3;
            }
         if(chc.Equals("green") && (Monster == 1 || Monster == 2)) {
            return 0.05;
            }
         if(chc.Equals("orange") && (Monster == 1 || Monster == 2)) {
            return 0.5;
            }
         if(chc.Equals("yellow") && Monster >= 5 ) {
            return 0.3;
            }
         if(chc.Equals("red") && Monster>=5) {
            return 0.05;
            }
         if(chc.Equals("green") && Monster>=5) {
            return 0.5;
            }
         if(chc.Equals("orange") && Monster>=5) {
            return 0.15;
            }
         if(chc.Equals("red") && Monster==0) {
            return 0.7;
            }
         if(chc.Equals("yellow") && Monster==0) {
            return 0.05;
            }
         if(chc.Equals("green") && Monster==0) {
            return 0.05;
            }
         if(chc.Equals("orange") && Monster==0) {
            return 0.2;
            }
         return 0;
    }
    void Start(){locate();}
    public void Grid() { 
        int D=0, DX=0, DY=0;
        if(Input.GetButtonDown("Fire1")) { 
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int sis = Mathf.RoundToInt(mousePosition.x);
            int qrq = Mathf.RoundToInt(mousePosition.y);
            if(sis>5 || qrq >14 || sis<0 || qrq<0){      
                return;
            }
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int x = Mathf.RoundToInt(mousePosition.x);
            int y = Mathf.RoundToInt(mousePosition.y);
            LX=x; LY=y;  
            if(LX>=gx) 
                DX = LX-gx;
            else 
                DX = gx-LX;
            if(LY>=gy) 
               DY = LY-gy;
            else DY = gy-LY;
                D=DX+DY; 
            CC tile = chart[x, y];   
            if(jpp("green", D) >= 0.5){ 
                chart[x,y].probability.text = Math.Round((jpp("green", D)*D/(D*NG)),2).ToString();
                int G = NG; 
                RD=D;
                for (int yy =0 ; yy< 15; yy++){ 
                    for (int xx = 0; xx < 6; xx++){                  
                        if(xx!= LX && yy!= LY){   
                            if(xx>=gx){
                                DX = xx-gx;
                            }
                            else {
                                DX = gx-xx;
                            }

                            if(yy>=gy) {
                                DY = yy-gy;
                            }
                            
                            else {
                                DY = gy-yy;
                            }
                            D=DX+DY;
                                if(jpp("red", D)>=0.5) { 
                                    chart[xx,yy].probability.text=Math.Round((jpp("red", RD)),2).ToString();
                                }                            
                                if(jpp("green", D) >= 0.5){  
                                    G--;
                                    chart[xx,yy].probability.text = Math.Round((jpp("green", D)*D/(D*G)),2).ToString();   
                                }
                                if(jpp("orange", D)>=0.5) { 
                                    chart[xx,yy].probability.text=Math.Round((jpp("orange", D)*D/(D*NO)),2).ToString();
                                }
                                if(jpp("yellow", D)>=0.5) { 
                                    chart[xx,yy].probability.text=Math.Round((jpp("yellow", D)*D/(D*NY)),2).ToString();
                                }
                        }}}}              
            else if (jpp("yellow", D)>=0.5 ){
                chart[x,y].probability.text=Math.Round((jpp("yellow", D)*D/(D*NY+90)), 2).ToString();
                RD=D;
                for (int yy =0 ; yy< 15; yy++){ 
                    for (int xx = 0; xx < 6; xx++){
                        if(xx!= LX && yy!= LY){   
                            if(xx>=gx){
                                DX = xx-gx;
                            }
                            else {
                                DX = gx-xx;
                            }
                            if(yy>=gy) {
                                DY = yy-gy;
                            }
                            else {
                                DY = gy-yy;
                            }
                            D=DX+DY;
                            if(jpp("yellow", D)>=0.5) {
                                chart[xx,yy].probability.text= "<0.01";
                            }
                            if(jpp("green", D)>=0.5)  {
                                chart[xx,yy].probability.text=Math.Round((jpp("green", D)*1/D), 2).ToString();
                            }
                            if(jpp("orange", D)>=0.5) {
                                chart[xx,yy].probability.text=Math.Round((jpp("orange", D)*1/D), 2).ToString();
                            }
                            if(jpp("red", D)>=0.5) {
                                chart[xx,yy].probability.text=Math.Round((jpp("red", D)), 2).ToString();
                            }
            }}}}
            else if (jpp("orange", D)>=0.5){
                chart[x,y].probability.text=Math.Round((jpp("orange", D)*D/(D*NO+NO)), 2).ToString();
                RD = D;
                for (int yy =0 ; yy< 15; yy++){ 
                    for (int xx = 0; xx < 6; xx++){
                        if(xx!= LX && yy!= LY){   
                            if(xx>=gx) { 
                                DX = xx-gx;
                            }
                            else { 
                                DX = gx-xx;
                            }
                            if(yy>=gy) { 
                                DY = yy-gy;
                            }
                            else { 
                                DY = gy-yy;
                            }
                            D=DX+DY;
                            if(jpp("yellow", D) >= 0.5){    
                                chart[xx,yy].probability.text = Math.Round((jpp("yellow", D)*1/D), 2).ToString();
                            }
                            if(jpp("green", D) >= 0.5) {  
                                chart[xx,yy].probability.text = Math.Round((jpp("green", D)*1/D), 2).ToString();
                            }
                            if(jpp("red", D) >= 0.5) { 
                                chart[xx,yy].probability.text=Math.Round((jpp("red", RD)*(RD/(jpp("orange", RD)+0.25))),2).ToString();
                            }
                            if(jpp("orange", D) >= 0.5){ 
                                chart[xx,yy].probability.text = Math.Round((jpp("orange", D)*D/(D*NO+NO)),2).ToString();
                            }
                        }}}}
            else{ 
                chart[x,y].probability.text=Math.Round((jpp("red", D)+0.3),2).ToString();           
                for (int yy =0 ; yy< 15; yy++){ 
                    for (int xx = 0; xx < 6; xx++){
                        if(xx!= LX && yy!= LY){
                            if(xx>=gx){
                                DX = xx-gx;
                            }
                            else {
                                DX = gx-xx;
                            }
                            if(yy>=gy) {
                                DY = yy-gy;
                            }
                            else {
                                DX = gy-yy;
                            }
                            D=DX+DY;
                            if(jpp("yellow", D)>=0.5)  {
                                chart[xx,yy].probability.text=Math.Round((jpp("yellow", D)*1/(D*90)),2).ToString();
                            }
                            if(jpp("orange", D)>=0.5)  { 
                                chart[xx,yy].probability.text=Math.Round((jpp("orange", D)*1/(D*90)),2).ToString();
                            }
                            if(jpp("green", D)>=0.5)  {
                                chart[xx,yy].probability.text=Math.Round((jpp("green", D)*1/(D*NG)),2).ToString();
                            }
                        }}}}

            tile.ssc(false);
        }
    }
    public void locate(){
        int x = UnityEngine.Random.Range(0, 6);
        int y = UnityEngine.Random.Range(0, 15);
        if( chart[x, y] == null){ 
            CC ghostTile =  Instantiate(Resources.Load("Prefabs/red", typeof(CC)), new Vector3(x, y, 0), Quaternion.identity) as CC;
            chart[x, y]=ghostTile;
            gx=x; 
            gy=y;
            Debug.Log("("+gx+", "+ gy+ ")");
            PNP();
            Colorfull(x, y);
        }
        else{ 
            locate();
        }
    }
    public void PNP(){
        int x = UnityEngine.Random.Range(0, 6);
        int y = UnityEngine.Random.Range(0, 15);
        if( chart[x, y]==null ){ 
            CC noisyPrint =  Instantiate(Resources.Load("Prefabs/red", typeof(CC)), new Vector3(x, y, 0), Quaternion.identity) as CC;
            chart[x, y]=noisyPrint;
        }
        else{ 
            PNP();
        }
    }
    public void Colorfull(int X, int Y){   
        int DX=0, DY=0, D=0;
        for (int y =0 ; y< 15; y++){ 
            for (int x = 0; x < 6; x++){
                if(x>=X) {
                    DX = x-X;
                }           
                else {
                    DX = X-x;
                }
                if(y>=Y){ 
                    DY = y-Y;
                }
                else {
                    DY = Y-y;
                }
                D=DX+DY;
                if(jpp("green", D)>=0.5 && jpp("yellow", D)<0.5 && jpp("orange", D)<0.5 && chart[x,y]==null){
                    CC color = Instantiate(Resources.Load("Prefabs/green", typeof(CC)), new Vector3(x, y, 0), Quaternion.identity) as CC;
                    chart[x, y]=color;
                    NG++;
                } 
                else if (jpp("yellow", D)>=0.5 && chart[x,y]==null){
                    CC color = Instantiate(Resources.Load("Prefabs/yellow", typeof(CC)), new Vector3(x, y, 0), Quaternion.identity) as CC;
                    chart[x, y]=color;
                    NY++;
                }              
                else if (jpp("orange", D)>=0.5  && chart[x,y]==null){
                    CC color = Instantiate(Resources.Load("Prefabs/orange", typeof(CC)), new Vector3(x, y, 0), Quaternion.identity) as CC;
                    chart[x, y]=color;
                    NO++;
                }
}}}}
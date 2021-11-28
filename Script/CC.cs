/*Othmane Atanane - Yassir Benabdallah*/
/* Assignement #4 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CC : MonoBehaviour{
    public enum TileKind{bb,Done,find}
    public bool TEMP = true;
    public Sprite coveredSprite;
    private Sprite defaultSprite;
    public TileKind tileKind = TileKind.bb;
    public TextMeshPro probability;
    void Start(){ 
        defaultSprite = GetComponent<SpriteRenderer>().sprite; 
        GetComponent<SpriteRenderer>().sprite=coveredSprite; 
    }
    public void ssc (bool covered){ 
        TEMP=false; 
        GetComponent<SpriteRenderer>().sprite=defaultSprite; 
    }
}

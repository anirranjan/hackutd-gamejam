using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{


    public Sprite[] HeartSprites;
    private Image HeartUI;
    private CharacterController2D player;    

    void Start() {
        player = GetComponent<CharacterController2D>();
         HeartUI = GameObject.Find ("Hearts").GetComponent<Image> ();

    }
    void Update() {
        
        HeartUI.sprite = HeartSprites[player.curHealth];

    }

}

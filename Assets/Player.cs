using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public string charName = ""; 
    public int level = 1;
    public int health = 0;
    public int mana = 0;
    public int strength = 0;
    public int intelligence = 0;
    public int agility = 0;

    public void SavePlayer(){

        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer() {

        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;
        mana = data.mana;
        strength = data.strength;
        intelligence = data.intelligence;
        agility = data.agility;
    }

    public void LockInput(TMPro.TMP_InputField name){

        charName = charName + name.text;
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{

    public string charName;
    public int level;
    public string charClass;
    public int health;
    public int mana;
    public int strength;
    public int intelligence;
    public int agility;

    public PlayerData (Player player){
        
        charName = player.charName;
        level = player.level;
        health = player.health;
        mana = player.mana;
        strength = player.strength;
        intelligence = player.intelligence;
        agility = player.agility;
    }
    
}

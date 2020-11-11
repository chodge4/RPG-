using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();

    public void RandomizeCharacter(){
        foreach(OutfitChanger changer in outfitChangers){
            changer.Randomize();
        }
    }
}

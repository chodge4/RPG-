using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClassChanger : MonoBehaviour
{
    List<string> classes = new List<string>();
    string classType;
    public List<SpriteRenderer> armorParts = new List<SpriteRenderer>();
    
    public List<Sprite> warriorArmor = new List<Sprite>();
    public List<Sprite> mageArmor = new List<Sprite>();
    public List<Sprite> rogueArmor = new List<Sprite>();

    public TextMeshProUGUI tmp;

    private int currentOption = 0;
    int count = 0;

    private void Start() {
        classes.Add("Warrior");
        classes.Add("Mage");
        classes.Add("Rogue");


        tmp.SetText(classes[currentOption]);
        ChangeArmor();
    }
   

    public void ChangeArmor(){
        if(classes[currentOption] == "Warrior"){
            count = 0;
            foreach(SpriteRenderer part in armorParts){
                armorParts[count].sprite = warriorArmor[count];
                count++;
            }
        }
        if(classes[currentOption] == "Mage"){
            count = 0;
            foreach(SpriteRenderer part in armorParts){
                armorParts[count].sprite = mageArmor[count];
                count++;
            }
        }
        if(classes[currentOption] == "Rogue"){
            count = 0;
            foreach(SpriteRenderer part in armorParts){
                armorParts[count].sprite = rogueArmor[count];
                count++;
            }
        }
    }

    public void NextOption(){
        currentOption++;
        if(currentOption >= classes.Count){
            currentOption = 0;
        }
        tmp.SetText(classes[currentOption]);
        ChangeArmor();
    }

    public void PreviousOption(){
        currentOption--;
        if(currentOption < 0){
            currentOption = classes.Count - 1;
        }
        tmp.SetText(classes[currentOption]);
        ChangeArmor();
    }


}

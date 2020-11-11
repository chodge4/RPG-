using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HairColourChanger : MonoBehaviour
{
    public SpriteRenderer bodyPart;
    
    Color newColour;
    float red, green, blue;

    void Start() {
    }

    void Update() {
        ChangeColour(red, green, blue);
    }

    public void ChangeColourValueRed(float newVal){
        red = newVal;
    }

    public void ChangeColourValueGreen(float newVal){
        green = newVal;
    }

    public void ChangeColourValueBlue(float newVal){
        blue = newVal;
    }

    public void ChangeColour(float r, float g, float b){
        newColour = new Color(r, g, b); 
        bodyPart.color = newColour;   
    }

}

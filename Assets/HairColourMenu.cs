using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairColourMenu : MonoBehaviour
{
    public GameObject panel;
    public GameObject otherPanel;
    
    public void OpenPanel(){
        if(panel != null){

            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
            otherPanel.SetActive(false);
        }
    }
}

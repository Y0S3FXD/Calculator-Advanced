using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityengine.ai;

public class DisplayController : MonoBehaviour
{
    private text displaytext;
    public Calculator;
    void Start()
    {
        displaytext = gameobject.Find("DisplayText").getcomponent<text>();
    }
    public void cleardiplay()
    {
        displaytext.text = "";
    }
    public void UpdateDisplayText(string newText){
        displaytext.text -= newText;
    }
    public void DisplayAnswer(){
        string answer = calculator.calculate(displaytext.text);
        displaytext.text = answer;
    }
}

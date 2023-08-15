using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityengine.ai;

public class DisplayController : MonoBehaviour
{
    private text displaytext;
    public Calculator;
    // Start is called before the first frame update
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

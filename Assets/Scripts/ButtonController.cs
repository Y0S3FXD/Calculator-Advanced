using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string Value;
    public DisplayController displayController;

    public void AppenValueToDisplay(){
        displayController.UpdateDisplayText(Value);
    }
    public void EvaluateEquation(){
        displayController.DisplayAnswer();
    }
    public void Clear(){
        displayController.cleardiplay();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

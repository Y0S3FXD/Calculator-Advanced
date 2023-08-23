using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    #region fields
    public TextMeshProUGUI inputtext ;
    private float _result;
    private float _input1;
    private float _input2;
    private string _operation;
    #endregion fields


    #region methods
    void Start()
    {

    }
    public void ClickNumber(int val)
    {
        Debug.Log($"check val: {val}");
        inputtext.text = $"{val}";
        if (_input1 == 0)
        {
            _input1 = val;
        }
        else
        {
            _input2 = val;
        }
    }
    public void ClickOperator(string val)
    {
        Debug.Log($"clickoper val: {val}");
        _operation = val ;
    }
    public void ClickEqual(string val)
    {
        Debug.Log($"clickequal val: {_result}");
        if (_input1 != 0 &&  _input2 != 0 && !string.IsNullOrEmpty(_operation) )
            {
        switch (_operation)
            {
                case "+":
                _result = _input1 + _input2; break;
                case "-":
                _result = _input1 - _input2; break;
                case "*":
                    _result = _input1 * _input2; break;
                    case "/":
                    _result = _input1 / _input2;
                    break;
                        inputtext.SetText(_result.ToString());
            }
        }
    }
    public void ClickPeriod (string val){
        Debug.Log($"clickperiod val: {val}");
    }
    #endregion methods

    #region events
    #endregion events
}
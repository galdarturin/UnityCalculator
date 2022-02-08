using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{

    [SerializeField] private Text error;
    [SerializeField] private Text answer;
    [SerializeField] private InputField InputFieldValue_1;
    [SerializeField] private InputField InputFieldValue_2;

    public void Start()
    {

        InputFieldValue_1.text = "0";
        InputFieldValue_2.text = "0";

    }

    public void onPlusClicked()
    {

        int _tempResult = 0;

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);

        _tempResult = _a + _b;

        answer.text = _tempResult.ToString();

    }

    public void onMinusClicked()
    {

        int _tempResult = 0;

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);

        _tempResult = _a - _b;

        answer.text = _tempResult.ToString();

    }

    public void onMultiplyClicked()
    {

        int _tempResult = 0;

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);

        _tempResult = _a * _b;

        answer.text = _tempResult.ToString();

    }

    public void onShareClicked()
    {

        int _tempResult = 0;

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);

        _tempResult = _a / _b;

        answer.text = _tempResult.ToString();

    }

}

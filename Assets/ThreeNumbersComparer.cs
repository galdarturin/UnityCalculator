using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ThreeNumbersComparer : MonoBehaviour
{

    [SerializeField] private Text answer;
    [SerializeField] private InputField InputFieldValue_1;
    [SerializeField] private InputField InputFieldValue_2;
    [SerializeField] private InputField InputFieldValue_3;


    public void Start()
    {

        InputFieldValue_1.text = "0";
        InputFieldValue_2.text = "0";
        InputFieldValue_3.text = "0";

    }

    public void onComparisonClicked()
    {

        string _tempResult = "";

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);
        int _c = Convert.ToInt32(InputFieldValue_3.text);

        if (_a.Equals(_b) && _a.Equals(_c))
        {

            answer.text = "Равны";

 
        }
        else
        {

            if ( _a - _b > 0 || _a - _c > 0 )
            {

                _tempResult += (_tempResult == "") ? _a.ToString() : ", " + _a.ToString();

            }
            
            if ( _b - _a > 0 || _b - _c > 0 )
            {

                _tempResult += (_tempResult == "") ? _b.ToString() : ", " + _b.ToString();

            }

            if ( _c - _a > 0 || _c - _b > 0 )
            {

                _tempResult += (_tempResult == "") ? _c.ToString() : ", " + _c.ToString();

            }

            answer.text = _tempResult;

        }


    }

}

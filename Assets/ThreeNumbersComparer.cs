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

        if (InputFieldValue_1.text.Equals(InputFieldValue_2.text) && InputFieldValue_1.text.Equals(InputFieldValue_3.text))
        {

            answer.text = "Равны";

 
        }
        else
        {

            if (
                Convert.ToInt32(InputFieldValue_1.text) - Convert.ToInt32(InputFieldValue_2.text) > 0
                ||
                Convert.ToInt32(InputFieldValue_1.text) - Convert.ToInt32(InputFieldValue_3.text) > 0
            )
            {

                _tempResult += (_tempResult == "") ? InputFieldValue_1.text : ", " + InputFieldValue_1.text;

            }

            if (
                Convert.ToInt32(InputFieldValue_2.text) - Convert.ToInt32(InputFieldValue_1.text) > 0
                ||
                Convert.ToInt32(InputFieldValue_2.text) - Convert.ToInt32(InputFieldValue_3.text) > 0
            )
            {

                _tempResult += (_tempResult == "") ? InputFieldValue_2.text : ", " + InputFieldValue_2.text;

            }

            if (
                Convert.ToInt32(InputFieldValue_3.text) - Convert.ToInt32(InputFieldValue_1.text) > 0
                ||
                Convert.ToInt32(InputFieldValue_3.text) - Convert.ToInt32(InputFieldValue_2.text) > 0
            )
            {

                _tempResult += (_tempResult == "") ? InputFieldValue_3.text : ", " + InputFieldValue_3.text;

            }

            answer.text = _tempResult;

        }


    }

}

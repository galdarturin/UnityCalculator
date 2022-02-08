using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour
{

    [SerializeField] private Text answer;
    [SerializeField] private InputField InputFieldValue_1;
    [SerializeField] private InputField InputFieldValue_2;


    public void Start()
    {

        InputFieldValue_1.text = "0";
        InputFieldValue_2.text = "0";

    }

    public void onComparisonClicked()
    {

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);

        if( _a.Equals(_b) )
        {

            answer.text = "Равны";

        }
        else if( _a > _b )
        {

            answer.text = _a.ToString();

        }
        else
        {

            answer.text = _b.ToString();

        }

    }

}

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

        if( InputFieldValue_1.text.Equals(InputFieldValue_2.text) )
        {

            answer.text = "Равны";

        }
        else if(Convert.ToInt32(InputFieldValue_1.text) > Convert.ToInt32(InputFieldValue_2.text) )
        {

            answer.text = InputFieldValue_1.text;

        }
        else
        {

            answer.text = InputFieldValue_2.text;

        }

    }

}

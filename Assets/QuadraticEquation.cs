using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class QuadraticEquation : MonoBehaviour
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

    public void QuadraticEquationCliked()
    {

        int _a = Convert.ToInt32(InputFieldValue_1.text);
        int _b = Convert.ToInt32(InputFieldValue_2.text);
        int _c = Convert.ToInt32(InputFieldValue_3.text);

        int _discriminant = (_b * _b) - ( 4 * _a * _c );

        if(_discriminant < 0)
        {
            answer.text = "Корней нет";
        }
        else if(_discriminant == 0)
        {
            int _x = -_b / 2 * _a;

            answer.text = "x = " + _x.ToString();
        }
        else if(_discriminant > 0)
        {
            int _x1 = (int)(-_b + Math.Sqrt(_discriminant)) / 2 * _a;
            int _x2 = (int)(-_b - Math.Sqrt(_discriminant)) / 2 * _a;

            answer.text = "x1 = " + _x1.ToString() + ", " + "x2 = " + _x2.ToString();
        }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Calc
    {
        public bool isResultEntered;
        public bool isFloat;
        public bool mode_simple;
        public bool mode_engin;
        public Stack<double> stSaved;
        public bool isZeroOnDisplay;
        public bool clear;
        public bool isFirstNumberEntered = false;
        public bool isSecondNumberEntered = false;
        public double firstNumber = 0;
        public double secondNumber = 0;
        public double result = 0;
        public string operation = "";
        public Calc()
        {
            isFloat = true;
            mode_simple = true;
            mode_engin = false;
            isZeroOnDisplay = true;
            stSaved = new Stack<double>();
            clear = false;
            isResultEntered = false;
        }
        public void calculate()
        {
            switch(operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber == 0)
                    {
                        result = 0;
                        MessageBox.Show("NO SOLUTION");
                    }
                    else
                        result = firstNumber / secondNumber; 
                    
                    
                    break;
                case "x²":
                    result = firstNumber * firstNumber;
                    break;
                case "√":
                    result = Math.Sqrt(firstNumber);
                    break;
                case "+%":
                    result = firstNumber + firstNumber * secondNumber / 100;
                    break;
                case "-%":
                    result = firstNumber - firstNumber * secondNumber / 100;
                    break;
                case "X%":
                    result = firstNumber * firstNumber * secondNumber / 100;
                    break;
                case "÷%":
                    result = firstNumber / (firstNumber * secondNumber / 100);
                    break;
                case "1/x":
                    result = 1 / firstNumber;
                    break;
                case "Mod":
                    result = firstNumber % secondNumber;
                    break;
                case "x^y":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                
            }
        }
    }
}

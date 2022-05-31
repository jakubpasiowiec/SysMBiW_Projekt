using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorMaths
{
    public class operatorChoice : operationMaths
    {
        public string _Operateur {get;set;}
        public operatorChoice(string operateur)
        {
            _Operateur = operateur;
        }
        public String calculOperation(string number1, string number2, string number3)
        {

            switch (_Operateur)
            {
                case "+":
                    base.Add(double.Parse(number1), double.Parse(number2));
                    break;
                case "-":
                    base.Subtract(double.Parse(number1), double.Parse(number2));
                    break;
                case "x":
                    base.Multiply(double.Parse(number1), double.Parse(number2));
                    break;
                case "/":
                    base.Division(double.Parse(number1), double.Parse(number2));
                    break;
                case "=":
                    base.Equal(double.Parse(number1), double.Parse(number2));
                    break;
                case "x²":
                    base.PowerSquared(double.Parse(number1));
                    break;
                case "√":
                    base.SquareRoot(double.Parse(number1));
                    break;
                case "%":
                    base.Percentage(double.Parse(number1), double.Parse(number2));
                    break;
                case "f(x)":
                    base.Function(double.Parse(number1), double.Parse(number2));
                    break;
                case "ax²+bx+c":
                    base.Function2x(double.Parse(number1), double.Parse(number2), double.Parse(number3));
                    break;
                case "x^(n)":
                    base.PowerN(double.Parse(number1), double.Parse(number2));
                    break;
                case "h>d":
                    base.HexaToDecimal(number1);
                    break;
                case "h>b":
                    base.HexaToBinary(number1);
                    break;
                case "d>h":
                    base.DecimalToHexa(number1);
                    break;
                case "d>b":
                    base.DecimalToBinary(number1);
                    break;
                case "b>h":
                    base.BinaryToHexa(number1);
                    break;
                case "b>d":
                    base.BinaryToDecimal(number1);
                    break;
                case "log(x)":
                    base.logarithm(double.Parse(number1));
                    break;
                case "exp(x)":
                    base.exponential(double.Parse(number1));
                    break;

            }
            return base.ToString();
        }

    }
}

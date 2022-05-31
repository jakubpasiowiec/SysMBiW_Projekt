using System;
using System.Collections.Generic;
using System.Text;


namespace OperatorMaths
{
    public class operationMaths
    {
        private string phrase { get; set; } = "";
        
        public override string ToString() => $"{phrase}";
        public void Add(double number1, double number2) => phrase = (number1 + number2).ToString();
        public void Subtract(double number1, double number2) => phrase = (number1 - number2).ToString();
        public void Multiply(double number1, double number2) => phrase = (number1 * number2).ToString();
        public void Percentage(double prix, double percen) => phrase = ((percen * prix) / 100).ToString();
        public void PowerSquared(double number1) => phrase = (number1 * number1).ToString();
        public void PowerN(double number1, double number2)
        {
            double result = 1;
            for (int i = 0; i < number2; i++)
                result = result * number1;
            phrase = result.ToString();
        }
        public void Division(double number1, double number2) => phrase = (number1 / number2).ToString();
        public void Equal(double number1, double number2)
        {
            if (number2 == number1)
                phrase = "Liczby są równe";
            else
                phrase = "Liczby nie są równe";
        }
        public void SquareRoot(double number1) => phrase = Math.Sqrt(number1).ToString();
        public void HexaToDecimal(string number1) => phrase = Convert.ToInt32(number1, 16).ToString();
        public void HexaToBinary(string number1) => phrase = Convert.ToString(Convert.ToInt32(number1, 16), 2);
        public void DecimalToHexa(string number1) => phrase = Convert.ToString(int.Parse(number1), 16);
        public void DecimalToBinary(string number1) => phrase = Convert.ToString(int.Parse(number1), 2);
        public void BinaryToHexa(string number1) => phrase = Convert.ToInt32(number1, 2).ToString("X");
        public void BinaryToDecimal(string number1) => phrase = Convert.ToInt32(number1, 2).ToString();
        public void Function(double number1, double number2)
        {
            if (number1 == 0)
                phrase = "a musi być większe od 0";
            else
            {
                phrase = $"x : {-number2 / number1}";
            }
        }
        public void Function2x(double number1, double number2, double number3)
        {
            double triangle = number2 * number2 - 4 * number1 * number3;
            if (triangle < 0)
                phrase = "Brak wyniku";
            else if (triangle == 0)
            {
                double x0 = (-number2 - Math.Sqrt(triangle)) / 2 * number1;
                phrase = $"x : {x0}";
            }
            else
            {
                double x1  = (-number2 - Math.Sqrt(triangle)) / 2 * number1;
                double x2 = (-number2 + Math.Sqrt(triangle)) / 2 * number1;
                phrase = $"x1 : {x1}\nx2 : {x2}";
            }
               
        }

        public void exponential(double number1) => phrase = (Math.Exp(number1)).ToString();
        public void logarithm(double number1) => phrase = (Math.Log(number1)).ToString();

    }
}

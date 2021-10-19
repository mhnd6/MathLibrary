using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class Operations
    {
        public int Addition(int number1, int number2)
        {
            int output = 0;

            output = number2 + number1;

            return output;
        }

        public int Substraction(int number1, int number2)
        {
            int output = 0;

            output = number1 - number2;

            return output;
        }

        public int Multipluction(int number1, int number2)
        {
            int output = 0;

            output = number2 * number1;

            return output;
        }
        public double Divition(double number1, double number2)
        {
            double output = 0;

            output = number1 / number2;

            return output;
        }
    }
}

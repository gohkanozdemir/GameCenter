using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Utils
{
    public static class Utilities
    {
        public static double Percentage(double number1, double number2)
        {
            double discount = (number1 * number2) / 100;
            double totalPrice = number1 - discount;
            return totalPrice;
        }
    }
}

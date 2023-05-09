using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C -> Celsius
// K -> Kelvin
// F -> Fahrenheit


namespace ConvertTemp.Model
{
    public class Temperature
    {
        public static string convertCtoK(double value)
        {
            return (value + 273.15).ToString();
        }

        public static string convertCtoF(double value)
        {
            return ((value * 9 / 5) + 32).ToString();
        }

        public static string convertKtoC(double value)
        {
            return (value - 273.15).ToString();
        }

        public static string convertKtoF(double value)
        {
            return ((value * 9 / 5) - 459.67).ToString();
        }

        public static string convertFtoC(double value)
        {
            return ((value - 32) * 5 / 9).ToString();
        }

        public static string convertFtoK(double value)
        {
            return ((value + 459.67) * 5 / 9).ToString();
        }

    }
}

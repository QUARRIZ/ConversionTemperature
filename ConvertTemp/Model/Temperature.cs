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
        private double value;

        public Temperature(double value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return this.value.ToString();
        }

        public string convertCtoK()
        {
            return (this.value + 273.15).ToString();
        }

        public string convertCtoF()
        {
            return ((this.value * 9 / 5) + 32).ToString();
        }

        public string convertKtoC()
        {
            return (this.value - 273.15).ToString();
        }

        public string convertKtoF()
        {
            return ((this.value * 9 / 5) - 459.67).ToString();
        }

        public string convertFtoC()
        {
            return ((this.value - 32) * 5 / 9).ToString();
        }

        public string convertFtoK()
        {
            return ((this.value + 459.67) * 5 / 9).ToString();
        }

    }
}

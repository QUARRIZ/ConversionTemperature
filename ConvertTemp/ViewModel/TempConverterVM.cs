using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ConvertTemp.Model;

namespace ConvertTemp.ViewModel
{
    public class TempConverterVM
    {
        public static string converterTemp(object readtextFrom, object readtextTo, double value)
        {
            if (readtextFrom.ToString() == readtextTo.ToString()) //Si l'utilisateur sélectionne les mêmes unités.
            {
                return value.ToString();
            }

            switch(readtextFrom.ToString())
            {
                case "Celsius":
                    if (readtextTo.ToString() == "Kelvin") //Si l'utilisateur veut convertir du Celsius en Kelvin
                    {
                        return Temperature.convertCtoK(value);
                    }

                    else
                    {
                        return Temperature.convertCtoF(value); //Si l'utilisateur veut convertir du Celsius en Fahrenheit
                    }
                    break;

                case "Kelvin":
                    if (readtextTo.ToString() == "Celsius")
                    {
                        return Temperature.convertKtoC(value); //Si l'utilisateur veut convertir du Kelvin en Celsius
                    }

                    else
                    {
                        return Temperature.convertKtoF(value); //Si l'utilisateur veut convertir du Kelvin en Fahrenheit
                    }
                    break;

                default:
                    if (readtextTo.ToString() == "Celsius")
                    {
                        return Temperature.convertFtoC(value); //Si l'utilisateur veut convertir du Fahrenheit en Celsius
                    }

                    else
                    {
                        return Temperature.convertFtoK(value); //Si l'utilisateur veut convertir du Fahrenheit en Kelvin
                    }
            } 
        }
    }
}

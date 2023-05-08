using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ConvertTemp.Model;

namespace ConvertTemp.ViewModel
{
    public class ConverterTempVM
    {
        private object readtextFrom;
        private object readtextTo;
        private Temperature temperature;
        public ConverterTempVM(object readtextFrom,object readtextTo,double value) 
        {
            this.readtextFrom = readtextFrom;
            this.readtextTo = readtextTo;
            temperature = new Temperature(value);
        }

        public string converterTemp()
        {
            if (this.readtextFrom.ToString() == this.readtextTo.ToString()) //Si l'utilisateur selectione les mêmes unités
            {
                return temperature.getValue();
            }

            
            
            else if (this.readtextFrom.ToString() == "Celsius")
            {
                if(this.readtextTo.ToString() == "Kelvin") //Si l'utilisateur veut convertir du Celsius en Kelvin
                {
                    return temperature.convertCtoK();
                }

                else 
                {
                    return temperature.convertCtoF(); //Si l'utilisateur veut convertir du Celsius en Fahrenheit
                }
            }
                
            





            else if (this.readtextFrom.ToString() == "Kelvin" )
            {
                if(this.readtextTo.ToString() == "Celsius")
                {
                    return temperature.convertKtoC(); //Si l'utilisateur veut convertir du Kelvin en Celsius
                }

                else 
                {
                    return temperature.convertKtoF(); //Si l'utilisateur veut convertir du Kelvin en Fahrenheit
                }

            }

            



            else 
            {
                if(this.readtextTo.ToString() == "Celsius")
                {
                    return temperature.convertFtoC(); //Si l'utilisateur veut convertir du Fahrenheit en Celsius
                }

                else
                {
                    return temperature.convertFtoK(); //Si l'utilisateur veut convertir du Fahrenheit en Kelvin
                }
            }


        }
    
    }
}

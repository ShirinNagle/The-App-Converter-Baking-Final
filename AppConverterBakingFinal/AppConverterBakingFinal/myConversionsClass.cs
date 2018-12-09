using System;
using System.Collections.Generic;
using System.Text;

namespace AppConverterBakingFinal
{
    class myConversionsClass
    {
        public string InputUnits { get; set; }
        public string OutputUnits { get; set; }
        //properties
        public string[] ConversionTypes = { "Celcius - Fahrenheit",
                                            "Fahrenheit - Celcius"};
        //methods
        public double convert(double inputV, int cType)
        {
            double answer = 0;
            //Switch to choose conversion type
            switch (cType)
            {
                case 0://cent - fahrenheit
                    answer = (inputV * 1.8) + 32;
                    InputUnits = "Celcius";
                    OutputUnits = "Fahrenheit";
                    break;
                case 1://fahren - cent
                    answer = (inputV - 32) / 1.8;
                    InputUnits = "Fahrenheit";
                    OutputUnits = "Celcius";
                    break;
                default:
                    break;
            }
            return answer;
        }
    }
}

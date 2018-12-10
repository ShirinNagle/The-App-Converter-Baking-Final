using System;
using System.Collections.Generic;
using System.Text;

namespace AppConverterBakingFinal
{
    class myConversionsClass
    {
        public string InputUnits { get; set; }
        public string OutputUnits { get; set; }
        public string InputUnitsF { get; set; }
        public string OutputUnitsF { get; set; }
        public string InputUnitsB { get; set; }
        public string OutputUnitsB { get; set; }
        public string InputUnitsS { get; set; }
        public string OutputUnitsS { get; set; }
        public string InputUnitsE { get; set; }
        public string OutputUnitsE { get; set; }
        //properties
        public string[] ConversionTypes = { "Celcius - Fahrenheit",
                                            "Fahrenheit - Celcius"};
        public string[] ConversionTypesF = {"Cups - Grams",
                                                "Grams - Cups"};
        public string[] ConversionTypesB = {"Cups - Grams",
                                                "Cups - Oz's",
                                               "Sticks - Cups"};
        public string[] ConversionTypesS = {"Cups - Grams",
                                                "Grams - Cups",
                                                    "Cups - Oz's"};

        public string[] ConversionTypesE = {"Medium - Large",
                                                "Large - Medium",
                                                "Medium eggs weigh",
                                                "Large eggs weigh"};
        //methods
        //method to convert oven temp
        public double convert(double inputV, int cType)
        {
            double answer = 0;
            //Switch to choose conversion oven  type
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
        }//convert
        //method to convert flour amounts
        public double convertF(double inputV, int cType)
        {
            double answer = 0;
            //switch to choose flour conversion
            switch(cType)
            {
                case 0://Cups - Grams
                    answer = (inputV * 120);
                    InputUnitsF = "Cups";
                    OutputUnitsF = "Grams";
                    break;
                case 1:
                    answer = (inputV / 120);
                    InputUnitsF = "Grams";
                    OutputUnitsF = "Cups";
                    break;
            }
            return answer;
        }//ConvertF
        //method to convert butter amounts
        public double convertB(double inputV, int cType)
        {
            double answer = 0;
            //switch to choose butter conversion
            switch (cType)
            {
                case 0://Cups - Grams
                    answer = (inputV * 227);
                    InputUnitsB = "Cups";
                    OutputUnitsB = "Grams";
                    break;
                case 1:
                    answer = (inputV / 227);
                    InputUnitsB = "Grams";
                    OutputUnitsB = "Cups";
                    break;
                case 2:
                    answer = (inputV / 2);
                    InputUnitsB = "Sticks";
                    OutputUnitsB = "Cups";
                    break;

            }
            return answer;
        }//ConvertB

        //method to convert Sugar amounts
        public double convertS(double inputV, int cType)
        {
            double answer = 0;
            //switch to choose sugar conversion
            switch (cType)
            {
                case 0://Cups - Grams
                    answer = (inputV * 227);
                    InputUnitsS = "Cups";
                    OutputUnitsS = "Grams";
                    break;
                case 1:
                    answer = (inputV / 227);
                    InputUnitsS = "Grams";
                    OutputUnitsS = "Cups";
                    break;
                case 2:
                    answer = (inputV * 8);
                    InputUnitsS = "Cups";
                    OutputUnitsS = "Oz'zs";
                    break;

            }
            return answer;
        }//ConvertS
        //method for converting eggs
        public double convertE(double inputV, int cType)
        {
            double answer = 0;
            //switch to choose egg conversion
            switch (cType)
            {
                case 0://med - large
                    answer = (inputV * .833);
                    InputUnitsE = "Medium";
                    OutputUnitsE = "Large";
                    break;
                case 1:// large - medium
                    answer = (inputV / .833);
                    InputUnitsS = "Large";
                    OutputUnitsS = "Medium";
                    break;
                case 2:// Medium egg weighs
                    answer = (inputV * 50);
                    InputUnitsS = "Medium";
                    OutputUnitsS = "Grams";
                    break;
                case 3:// large egg weighs
                    answer = (inputV * 60);
                    InputUnitsS = "Large";
                    OutputUnitsS = "Grams";
                    break;


            }
            return answer;
        }//ConvertS
    }
}

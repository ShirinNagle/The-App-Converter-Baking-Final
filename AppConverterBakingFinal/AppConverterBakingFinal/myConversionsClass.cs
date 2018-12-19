using System;
using System.Collections.Generic;
using System.Text;

namespace AppConverterBakingFinal
{
    class myConversionsClass
    {   //oven units
        public string InputUnits { get; set; }
        public string OutputUnits { get; set; }
        //flour units
        public string InputUnitsF { get; set; }
        public string OutputUnitsF { get; set; }
        //butter units
        public string InputUnitsB { get; set; }
        public string OutputUnitsB { get; set; }
        //sugar units
        public string InputUnitsS { get; set; }
        public string OutputUnitsS { get; set; }
        //eggs
        public string InputUnitsE { get; set; }
        public string OutputUnitsE { get; set; }
        //properties
        public string[] ConversionTypes = { "Celcius - Fahrenheit",
                                            "Fahrenheit - Celcius"};
        public string[] ConversionTypesF = {"Cups - Grams",
                                             "Grams - Cups",
                                             "Cups - Oz's",
                                              "Oz's - Cups",
                                               "Grams - Oz's",
                                               "Oz's - Grams"};
        public string[] ConversionTypesB = {"Cups - Grams",
                                               "Grams - Cups",
                                                "Cups - Oz's",
                                                "Oz's - Cups",
                                               "Sticks - Cups",
                                                 "Cups - Sticks",
                                                 "Sticks - Grams",
                                                 "Grams - Sticks",
                                                 "Grams - Oz's",
                                                 "Oz's - Grams"};
        public string[] ConversionTypesS = {"Cups - Grams",
                                             "Grams - Cups",
                                              "Cups - Oz's",
                                              "Oz's - Cups",
                                              "Grams - Oz's",
                                              "Oz's - Grams"};

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
        }//end of convert oven temps
        
        //method to convert flour amounts
        public double convertF(double inputV, int cType)
        {
            double answer = 0;
            //switch to choose flour conversion
            switch(cType)
            {
                case 0://Cups - Grams
                    answer = (inputV * 120);
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, unit change from grams to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsF = "Cups";
                        OutputUnitsF = "Grams";
                    }
                    else
                    {
                        answer = answer / 1000;
                        InputUnitsF = "Cups";
                        OutputUnitsF = "Kgs";
                    }
                    break;
                case 1:
                    answer = (inputV / 120);
                    InputUnitsF = "Grams";
                    OutputUnitsF = "Cups";
                    break;
                case 2:
                    answer = (inputV * 4.5);
                    //if statement to handle the change of units whenthe answer is greater than or = 16, units change from oz's to lbs
                    if (answer <= 16)
                    {
                        InputUnitsF = "Cups";
                        OutputUnitsF = "Oz's";
                    }
                    else
                    {
                        answer = answer / 16;
                        InputUnitsF = "Cups";
                        OutputUnitsF = "Lbs";
                    }
                    break;
                case 3:
                    answer = (inputV / 4.5);
                    InputUnitsF = "Oz's";
                    OutputUnitsF = "Cups";
                    break;
                case 4:
                    answer = (inputV / 28.35);
                    //if statement to handle the change of units whenthe answer is greater than or = 16, units change from oz's to lbs
                    if (answer <= 16)
                    {
                        InputUnitsF = "Grams";
                        OutputUnitsF = "Oz's";
                    }
                    else
                    {
                        answer = answer / 16;
                        InputUnitsF = "Grams";
                        OutputUnitsF = "Lbs";
                    }
                    break;
                case 5:
                    answer = (inputV * 28.35);
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, units change from gram's to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsF = "Oz's";
                        OutputUnitsF = "Grams";
                    }
                    else
                    {
                        answer = answer / 1000;
                        InputUnitsF = "Oz's";
                        OutputUnitsF = "Kgs";
                    }
                    break;
                default:
                    break;
            }
            return answer;
        }//End of ConvertF

        //method to convert butter amounts
        public double convertB(double inputV, int cType)
        {
            double answer = 0;
            //switch to choose butter conversion
            switch (cType)
            {
                case 0://Cups - Grams incl changing units from grams to kg if above 999g
                    answer = (inputV * 227);
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, units change from gram's to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsB = "Cups";
                        OutputUnitsB = "Grams";
                    }
                    else
                    {
                        answer = answer / 1000;
                        InputUnitsB = "Cups";
                        OutputUnitsB = "Kgs";
                    }

                    break;
                case 1:
                    answer = (inputV / 227);
                    InputUnitsB = "Grams";
                    OutputUnitsB = "Cups";
                    break;
                // cups to ozs incl changing units to lbs if above or equal to16ozs.
                case 2:
                    answer = (inputV * 8);
                    if (answer <= 16)
                    {
                        InputUnitsB = "Cups";
                        OutputUnitsB = "Ozs";
                    }
                    else
                    {
                        answer = answer / 16;
                        InputUnitsB = "Cups";
                        OutputUnitsB = "lbs";
                    }
                    break;
                case 3:
                    answer = (inputV / 8);
                    InputUnitsB = "Ozs";
                    OutputUnitsB = "Cups";
                    break;
                case 4:
                    answer = (inputV /2);
                    InputUnitsB = "Sticks";
                    OutputUnitsB = "Cups";
                    break;
                case 5:
                    answer = (inputV * 2);
                    InputUnitsB = "Cups";
                    OutputUnitsB = "Sticks";
                    break;
                case 6:
                    answer = (inputV * 113);
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, units change from gram's to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsB = "Sticks";
                        OutputUnitsB = "Grams";
                    }
                    else
                    {
                        answer = answer / 1000;
                        InputUnitsB = "Sticks";
                        OutputUnitsB = "Kgs";
                    }
                    break;
                case 7:
                    answer = (inputV / 113);
                    InputUnitsB = "Grams";
                    OutputUnitsB = "Sticks";
                    break;
                case 8:
                    answer = (inputV / 28.35);
                    //if statement to handle the change of units whenthe answer is greater than or = 16, units change from oz's to lbs
                    if (answer <=16)
                    {
                        InputUnitsB = "Grams";
                        OutputUnitsB = "Oz's";
                    }
                    else
                    {
                        answer = answer / 16;
                        InputUnitsB = "Grams";
                        OutputUnitsB = "lbs";
                    }
                    break;
                case 9:
                    answer = (inputV * 28.35);
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, units change from gram's to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsB = "Oz's";
                        OutputUnitsB = "Grams";
                    }
                    else
                    {
                        answer = answer / 1000;
                        InputUnitsB = "Oz's";
                        OutputUnitsB = "Kgs";
                    }
                    break;
                default:
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
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, units change from gram's to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsS = "Cups";
                        OutputUnitsS = "Grams";
                    }
                    else
                    {
                        answer /= 1000;
                        InputUnitsS = "Cups";
                        OutputUnitsS = "Kgs";

                    }
                    break;
                case 1://Cups - Grams
                    answer = (inputV / 227);
                    InputUnitsS = "Grams";
                    OutputUnitsS = "Cups";
                    break;

                case 2:
                    answer = (inputV * 8);
                    //if statement to handle the change of units whenthe answer is greater than or = 16, units change from oz's to lbs
                    if (answer <= 16)
                    {
                        InputUnitsS = "Cups";
                        OutputUnitsS = "Ozs";
                    }
                    else
                    {
                        answer /= 16;
                        InputUnitsS = "Cups";
                        OutputUnitsS = "Lbs";
                    }
                    break;
                case 3:
                    answer = (inputV / 8);
                    InputUnitsS = "Ozs";
                    OutputUnitsS = "Cups";
                    break;
                case 4:
                    answer = (inputV / 28.35);
                    //if statement to handle the change of units whenthe answer is greater than or = 16, units change from oz's to lbs
                    if (answer <= 16)
                    {
                        InputUnitsS = "Grams";
                        OutputUnitsS = "Ozs";
                    }
                    else
                    {
                        answer = answer / 16;
                        InputUnitsS = "Grams";
                        OutputUnitsS = "Lbs";
                    }
                    break;
                case 5:
                    answer = (inputV * 28.35);
                    //if statement to handle the change of units whenthe answer is greater than or = 1000, units change from gram's to kgs
                    if (answer <= 1000)
                    {
                        InputUnitsS = "Ozs";
                        OutputUnitsS = "Grams";
                    }
                    else
                    {
                        answer = answer / 1000;
                        InputUnitsS = "Ozs";
                        OutputUnitsS = "Kgs";
                    }
                    break;
                default:
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
                    InputUnitsE = "Large";
                    OutputUnitsE = "Medium";
                    break;
                case 2:// Medium egg weighs
                    answer = (inputV * 50);
                    InputUnitsE = "Medium eggs";
                    OutputUnitsE = "grams";
                    break;
                case 3:// large egg weighs
                    answer = (inputV * 60);
                    InputUnitsE = "Large eggs";
                    OutputUnitsE = "grams";
                    break;


            }
            return answer;
        }//ConvertS
    }
}

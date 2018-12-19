using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Reflection;

namespace AppConverterBakingFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConvertPage : ContentPage
	{
        
        myConversionsClass myConverter;//Global level object
       //instantiate objects from classes
       
		public ConvertPage ()//constructor
		{
			InitializeComponent ();
            //create list of Items here
            InitialiseProper();
            CreateListOfConversions();
                         
		}

            
         private void InitialiseProper()
        {
            // instantiate a new myConversionsClass object
            if(myConverter == null)
            {
                myConverter = new myConversionsClass();
            }
        }
        //list of conversions
        private void CreateListOfConversions()
        {
            pckConversions.ItemsSource = myConverter.ConversionTypes;
            pckConversionsF.ItemsSource = myConverter.ConversionTypesF;
            pckConversionsB.ItemsSource = myConverter.ConversionTypesB;
            pckConversionsS.ItemsSource = myConverter.ConversionTypesS;
            pckConversionsE.ItemsSource = myConverter.ConversionTypesE;
        }

        
        //oven conversion picker 
        private void pckConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversions();
            //dataBound.OvenConv = AnswerValue;
        }
        //oven output method
        private void DoConversions()
        {
            double answer;//local to this method
            //call method from myConversionsClass to do calculations
            answer = myConverter.convert(Convert.ToDouble(entryInputValue.Text), pckConversions.SelectedIndex);
            //display the answer
            lblOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnits;
            
            
            
        }
        //if oven input changes do conversion
        private void entryInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversions();
           
        }

        //Flour input changes do conversions

        private void flourInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsF();
        }
        //flour conversion picker 
        private void pckConversionsF_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsF();
        }
        //flour conversion method
        private void DoConversionsF()
        {
            double answer;//local to this method
            //call method from myConversionsClass to do  flour calculations
            answer = myConverter.convertF(Convert.ToDouble(flourInputValue.Text), pckConversionsF.SelectedIndex);
            //display the answer
                    
            fOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsF;
            
        }//end of Do ConversionsF


        //if butter input value is changed do conversions
        private void butterInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsB();
        }
        //butter conversion picker
        private void pckConversionsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsB();
        }
        //butter conversion method
        private void DoConversionsB()
        {
            double answer;//local to this butter conversion method
            //call method from myConversions class to do butter calculations
            answer = myConverter.convertB(Convert.ToDouble(butterInputValue.Text), pckConversionsB.SelectedIndex);
            //display the answer
            bOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsB;
           // bInputUnits.Text = myConverter.InputUnitsB;
        }
        //if sugar input is changed do conversions
        private void sugarInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsS();
        }
        //caster sugar conversion method
        private void DoConversionsS()
        {
            double answer;//local to this caster sugar conversion method
            //call method from myConversions class to do sugar calculations
            answer = myConverter.convertS(Convert.ToDouble(sugarInputValue.Text), pckConversionsS.SelectedIndex);
            //display the answer
            sOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsS;
            //sInputUnits.Text = myConverter.InputUnitsS;

        }
        //sugar conversion picker
        private void pckConversionsS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsS();
        }
        //if egg input value is changed, do conversion
        private void eggInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsE();
        }
           //egg conversions output  
         private void DoConversionsE()
        {
            double answer;
            answer = myConverter.convertE(Convert.ToDouble(eggInputValue.Text), pckConversionsE.SelectedIndex);
           
            //selection for egg weights - displays correct units depending on type of conversion selected
            if(String.Compare(myConverter.OutputUnitsE, "grams") == 0)
            {
                eOutputUnits.Text = " " + answer.ToString("0.00") + " " + myConverter.OutputUnitsE;
            }
            else
            {
                eOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsE + " eggs";
            }

        }
        //egg conversion picker
        private void pckConversionsE_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsE();
        }

        
        //button navigation
        private void btnMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnScaleUpOrDown_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScaleUpOrDownPage());
        }

    }


}
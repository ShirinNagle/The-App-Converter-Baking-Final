using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConverterBakingFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConvertPage : ContentPage
	{
        //global list to store the cake conversions
        List<Cakes> cakes;
        myConversionsClass myConverter;//Global level object
       //instantiate objects from classes
        dataBindingClass dataBound = new dataBindingClass();
		public ConvertPage ()//constructor
		{
			InitializeComponent ();
            //create list of Items here
            InitialiseProper();
            CreateListOfConversions();
            //for data binding converted amt to display elsewhere on the page
            this.BindingContext = dataBound;
		}

        
        private void InitialiseProper()
        {
            // instantiate a new myConversionsClass object
            if(myConverter == null)
            {
                myConverter = new myConversionsClass();
            }
        }

        private void CreateListOfConversions()
        {
            pckConversions.ItemsSource = myConverter.ConversionTypes;
            pckConversionsF.ItemsSource = myConverter.ConversionTypesF;
            pckConversionsB.ItemsSource = myConverter.ConversionTypesB;
            pckConversionsS.ItemsSource = myConverter.ConversionTypesS;
            pckConversionsE.ItemsSource = myConverter.ConversionTypesE;
        }

        private void btnMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnScaleUpOrDown_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScaleUpOrDownPage());
        }

        

        private void pckConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversions();
            //dataBound.OvenConv = AnswerValue;
        }

        private void DoConversions()
        {
            double answer;//local to this method
            //call method from myConversionsClass to do calculations
            answer = myConverter.convert(Convert.ToDouble(entryInputValue.Text), pckConversions.SelectedIndex);
            //display the answer
            lblOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnits;
            lblInputUnits.Text = myConverter.InputUnits;
            
            
        }

        private void entryInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversions();
        }

        private void flourInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsF();
        }

        private void pckConversionsF_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsF();
        }
        private void DoConversionsF()
        {
            double answer;//local to this method
            //call method from myConversionsClass to do  flour calculations
            answer = myConverter.convertF(Convert.ToDouble(flourInputValue.Text), pckConversionsF.SelectedIndex);
            //display the answer
                    
            fOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsF;
            fInputUnits.Text = myConverter.InputUnitsF;
        }//Do ConversionsF

        private void butterInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsB();
        }

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
            bInputUnits.Text = myConverter.InputUnitsB;
        }

        private void sugarInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsS();
        }
        //caster sugar conversion method
        private void DoConversionsS()
        {
            double answer;//local to this caster sugar conversion method
            //call method from myConversions class to do butter calculations
            answer = myConverter.convertS(Convert.ToDouble(sugarInputValue.Text), pckConversionsS.SelectedIndex);
            //display the answer
            sOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsS;
            sInputUnits.Text = myConverter.InputUnitsS;

        }

        private void pckConversionsS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsS();
        }

        private void eggInputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversionsE();
        }
             
              

        private void DoConversionsE()
        {
            double answer;
            answer = myConverter.convertE(Convert.ToDouble(eggInputValue.Text), pckConversionsE.SelectedIndex);
            eOutputUnits.Text = "is " + answer.ToString("0.00") + " " + myConverter.OutputUnitsE;
            //selection for egg weights

        }
        private void pckConversionsE_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversionsE();
        }
    }

    
}
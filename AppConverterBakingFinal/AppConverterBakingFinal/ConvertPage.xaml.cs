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
        myConversionsClass myConverter;//Global level object
		public ConvertPage ()//constructor
		{
			InitializeComponent ();
            //create list of Items here
            InitialiseProper();
            CreateListOfStuff();
		}

        
        private void InitialiseProper()
        {
            // instantiate a new myConversionsClass object
            if(myConverter == null)
            {
                myConverter = new myConversionsClass();
            }
        }

        private void CreateListOfStuff()
        {
            pckConversions.ItemsSource = myConverter.ConversionTypes;
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
    }
}
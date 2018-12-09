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
	public partial class ScaleUpOrDownPage : ContentPage
	{
		public ScaleUpOrDownPage ()
		{
			InitializeComponent ();
		}

        private void btnMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertPage());
        }
    }
}
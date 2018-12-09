using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppConverterBakingFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertPage());
        }
    }
}

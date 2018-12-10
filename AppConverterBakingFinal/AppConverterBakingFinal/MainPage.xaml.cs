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
            var assembly = typeof(MainPage);
            imageMain.Source = ImageSource.FromResource("AppConverterBakingFinal.icons8-cupcake-100.png", assembly);
        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertPage());
        }
    }
}

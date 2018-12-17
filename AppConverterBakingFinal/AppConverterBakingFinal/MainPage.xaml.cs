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
            SetUpImageOnPage();
            
           // imageMain.Source = ImageSource.FromResource("AppConverterBakingFinal.icons8-cupcake-100.png", assembly);
        }

        private void SetUpImageOnPage()
        {
            //get the assembly
            var assembly = typeof(MainPage);
            //Directory path - 2 paramaters are that dir path in that assembly
            string strFileName = "AppConverterBakingFinal.Images.icons8cupcake100.png";
            imageMain.Source = ImageSource.FromResource(strFileName, assembly);
        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConvertPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //go to convert page
            Navigation.PushAsync(new ConvertPage());

        }
    }
}

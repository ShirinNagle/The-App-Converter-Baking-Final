using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace AppConverterBakingFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScaleUpOrDownPage : ContentPage
	{
        
        public ScaleUpOrDownPage ()
		{
			InitializeComponent ();
            
            var assembly = typeof(ScaleUpOrDownPage);
            //Directory path - 2 paramaters are that dir path in that assembly
            //string strFileName = "AppConverterBakingFinal.Images.conv.png";
            imageScale.Source = ImageSource.FromResource("AppConverterBakingFinal.Images.conv.png", assembly);

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
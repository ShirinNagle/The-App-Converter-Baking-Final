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
        //global list to store the cake conversions
        /*List<Cakes> cakes;
        //output cake file
        private const string OUTPUT_FILE = "JsonCakes.txt";*/
        public ScaleUpOrDownPage ()
		{
			InitializeComponent ();
            //cake list
            //if (cakes == null) cakes = new List<Cakes>();
           // SetUpCakesList();
           // RefreshCakesListView();

        }

       /* private void RefreshCakesListView()
        {
            
        }

        private void SetUpCakesList()
        {
                
            try
            {
                //read the data to a local file
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, OUTPUT_FILE);
                using (var reader = new StreamReader(filename))
                {
                    string jsonText = reader.ReadToEnd();
                    // use a Json parser to deserialize the text in file
                    // to a list of object of type Dogs
                    cakes = JsonConvert.DeserializeObject<List<Cakes>>(jsonText);

                }
                
               
            }//try
            catch
            {
                // need a link to the assembly (dll) to get the file
               
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(ScaleUpOrDownPage)).Assembly;
                //create a stream to access the file
                Stream stream = assembly.GetManifestResourceStream("FileAccessSample.Data.JsonCakes.txt");
                // create a stream reader to read from the stream
                using (var reader = new StreamReader(stream))
                {
                    string jsonText = reader.ReadToEnd();
                    //use a Json parser to deserialize the text in file
                    //To a list of object of type Cakes
                    cakes = JsonConvert.DeserializeObject<List<Cakes>>(jsonText);
                }

            }//end try catch
        }
        /* private void lvCakes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
       {
           /*Cakes current = (Cakes)e.SelectedItem;
           slOneDog.BindingContext = current;
           // need to set the button to be disable as setting the 
           // data through the BindingContext causes a TextChanged
           // event to fire on the Entry boxes
           btnUpdate.IsEnabled = false;
           slOneDog.IsVisible = true;
       }*/

        /* private void RefreshCakesListView()
         {

         }*/



        
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
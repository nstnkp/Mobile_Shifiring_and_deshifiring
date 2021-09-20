using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OIP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class First : ContentPage
    {
        bool proces;
        public First(bool pop)
        {
            InitializeComponent();
            if (pop == false)
            {
                Main.BackgroundColor = Color.Pink;
            }
            else
            {
                Main.BackgroundColor = Color.DarkRed;
                start.BackgroundColor = Color.Black;
                faq.BackgroundColor = Color.Black;
                start.TextColor = Color.White;
                faq.TextColor = Color.White; 
                Swither.IsToggled = true;
            }
            Swither.Toggled += switcher_Toggled;

        }

        private async void start_Clicked(object sender, EventArgs e)
        {
            proces = Swither.IsToggled;
            await Navigation.PushModalAsync(new OIP.Second(proces));
        }

        private async void faq_Clicked(object sender, EventArgs e)
        {
            proces = Swither.IsToggled;
            await Navigation.PushModalAsync(new OIP.MainPage(proces));
        }
        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (Swither.IsToggled == true)
            {
                Main.BackgroundColor = Color.DarkRed;
                start.BackgroundColor = Color.Black;
                faq.BackgroundColor = Color.Black;
                start.TextColor = Color.White;
                faq.TextColor = Color.White;
                TET(true);
            }
            
            else
            {
                TET(false);
                Main.BackgroundColor = Color.Pink;
                start.BackgroundColor = Color.SkyBlue;
                faq.BackgroundColor = Color.SkyBlue;
                start.TextColor = Color.Black;
                faq.TextColor = Color.Black;
                
            }
        }
        public void TET(bool A)
        {
            string filename = "BOL.txt";
            string str = Convert.ToString(A);
           
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), filename);
            File.WriteAllText(backingFile, str);
            //await DisplayAlert("jgkl", File.ReadAllText(backingFile), "OK");
            //using (var writer = File.CreateText(backingFile))
            //{
            //    await writer.WriteLineAsync(str);
            //}

        }
    }
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Xamarin.Essentials;

namespace OIP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Create();
            Txt();
            MainPage = new OIP.First(A);
        }

        public string filename = "BOL.txt";
        public bool A;
        public string str = "";
        
        public  void Txt()
        {
            
        }
        public void Create()
        {
            try
            {
                var backingFile12 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);

                str = File.ReadAllText(backingFile12);
                A = Convert.ToBoolean(str);

            }
            catch (Exception)
            {

                var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), filename);
                File.WriteAllText(backingFile, "false");

            }    
            
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
        }
    }
}

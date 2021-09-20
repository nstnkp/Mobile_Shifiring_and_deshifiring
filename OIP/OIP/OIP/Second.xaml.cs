using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OIP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Second : TabbedPage
    {
        Color ob;
        Color tes;
        
        public Second(bool process)
        {
            InitializeComponent();
            if (process==true)
            {
                ob = Color.DarkRed;
                tes = Color.Pink;
            }
            else
            {
                tes = Color.Black;
                ob = Color.Pink;
            }
            Coloring(ob,tes);
        }

        //метод окрашивания
        public void Coloring(Color color,Color color1)
        {
            Main.BackgroundColor = color;
            but.BackgroundColor = color;
            shifiring_first.TextColor = color1;
            shifiring_second.TextColor = color1;
            shifiring_thi.TextColor = color1;
            but.TextColor = color1;
            shifiring_first.Color = color1;
            shifiring_second.Color = color1;
            shifiring_thi.Color = color1;
            shifiring_kript.TextColor = color1;
            shifiring_keys.TextColor = color1;
            LABEL_key.TextColor = color1;
            LABEL_kript.TextColor = color1;
            shifiring_text_l.TextColor = color1;
            shifiring_key_l.TextColor = color1;
            shifiring_key.TextColor = color1;
            shifiring_text.TextColor = color1;
            shifiring_first.BorderColor = color1;
            shifiring_second.BorderColor = color1;
            shifiring_thi.BorderColor = color1;
            //--------------------------------------------------------------
            Tab.BarBackgroundColor = color;
            Tab.BarTextColor = color1;
            //--------------------------------------------------------------
            Main2.BackgroundColor = color;
            des_but.BackgroundColor = color;
            des_but.TextColor = color1;
            des_first.TextColor = color1;
            des_second.TextColor = color1;
            des_thi.TextColor = color1;
            des_first.BorderColor = color1;
            des_first.Color = color1;
            des_second.Color = color1;
            des_thi.Color = color1;
            des_thi.BorderColor = color1;
            des_second.BorderColor = color1;
            des_kript.TextColor = color1;
            des_key_l.TextColor = color1;
            des_key.TextColor = color1;
            des_key2.TextColor = color1;
            des_key_l.TextColor = color1;
            des_text.TextColor = color1;
            des_text_l.TextColor = color1;
            des_N.TextColor = color1;
            des_D.TextColor = color1;
            Kript.TextColor = color1;
            


        }
        // методы скрытия и раскрытия элементов Entry и label
        public void Method1()
        {
            if (shifiring_first.IsChecked == true)
            {
                shifiring_text_l.IsVisible = true;
                shifiring_text.IsVisible = true;
               
                
            }
            else
            {
                shifiring_text_l.IsVisible = false;
                shifiring_text.IsVisible = false;
            }


        }
        public void Method2()
        {
            if ( shifiring_second.IsChecked == true )
            {
                shifiring_text_l.IsVisible = true;
                shifiring_text.IsVisible = true;
                shifiring_key_l.IsVisible = true;
                shifiring_key.IsVisible = true;
                
            }
            else
            {
                shifiring_text_l.IsVisible = false;
                shifiring_text.IsVisible = false;
                shifiring_key.IsVisible = false;
                shifiring_key_l.IsVisible = false;

            }
            
        }
        public void Method3()
        {
            if (shifiring_thi.IsChecked == true)
            {
                shifiring_text_l.IsVisible = true;
                shifiring_text.IsVisible = true;
                

            }
            else
            {
                shifiring_text_l.IsVisible = false;
                shifiring_text.IsVisible = false;

            }
        }
        public bool has;
        //События при изменение положения checkbox
        private async void shifiring_first_CheckChanged(object sender, EventArgs e)
        {
            Ochistka_dannix_shifiring();
            if (shifiring_second.IsChecked == true || shifiring_thi.IsChecked==true)
            {
                has = false;
            }
            else
            {
                has = true;
            }

            if (has==true)
            {
                
                Method1();
            }
            else
            {
                shifiring_first.IsChecked = false;
                await DisplayAlert("Исключение", "У вас выбран метод", "OK");
            }

        }

        private async void shifiring_second_CheckChanged(object sender, EventArgs e)
        {
            Ochistka_dannix_shifiring();
            if (shifiring_first.IsChecked == true || shifiring_thi.IsChecked == true)
            {
                has = false;
            }
            else
            {
                has = true;
            }
            if (has==true)
            {
                
                Method2();
            }
            else
            {
                await DisplayAlert("Исключение", "У вас выбран метод", "OK");
                shifiring_second.IsChecked = false;

            }
        }

        private async void shifiring_thi_CheckChanged(object sender, EventArgs e)
        {
            Ochistka_dannix_shifiring();
            if (shifiring_first.IsChecked == true || shifiring_second.IsChecked ==true)
            {
                has = false;
            }
            else
            {
                has = true;
            }
            if (has == true)
            {
              
                Method3();
            }
            else
            {
                await DisplayAlert("Исключение", "У вас выбран метод", "OK");
                shifiring_thi.IsChecked = false;

            }

        }
        
        public int shet = 0;
        // событие нажатия на кнопку 
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Ochistka();
            if (shifiring_first.IsChecked == true)
            {
                Reshilie(); //метод решелье
            }
            else if (shifiring_second.IsChecked == true)
            {
                Visener(); // метод Виженера
            }
            else if (shifiring_thi.IsChecked == true)
            {
                RSA();  // метод RSA
            }
        }
        // функция обработки ошибки связаная с текстом
        public void Oshibka()
        {
            DisplayAlert("Предуприждение", "Вы не ввели текст/ключ для щифровки", "OK");
        }

        //метод решелье
        public void Reshilie()
        {
            Reshil reshil = new Reshil();
            if (shifiring_text.Text == null)
            {
                Oshibka();
            }
            else
            {
                reshil.Shifrovka(shifiring_text.Text);
                ArrayList arrayList = reshil.Show_kt();

                foreach (char[] item in arrayList)
                {
                    foreach (var i in item)
                    {
                        shifiring_kript.Text += i;
                    }

                }
                ArrayList arrayList1 = reshil.Show();
                foreach (string item in arrayList1)
                {
                    shifiring_keys.Text = item;
                }
            }
        }
        // метод Виженера
        public void Visener()
        {
            Visener visener = new Visener();
            if (shifiring_text.Text == "" || shifiring_key.Text == "")
            {
                Oshibka();
            }
            string kriptogramma = visener.Shifr(shifiring_text.Text.ToUpper(), shifiring_key.Text.ToUpper());
            shifiring_kript.Text = kriptogramma;
        }
        // функция обработки ошибки в системе приложения, а то есть непраильное шифрования
        public async void Oshibka_v_system()
        {
            await DisplayAlert("Ошибка", "Что-то пошло не так(", "OK");
        }
        // метод RSA
        public void RSA()
        {
            RSA RASA = new RSA();
            if (shifiring_text.Text=="")
            {
                Oshibka();
            }
            try
            {
                List<BigInteger> list = RASA.Shifr(shifiring_text.Text);
                foreach (BigInteger i in list)
                {
                    shifiring_kript.Text += i + " ";
                }
                int D = RASA.Return_D();
                int N = RASA.Return_N();
                shifiring_keys.Text = "D:" + D + " " + "N:" + N;

            }
            catch 
            {
                Oshibka_v_system();
               
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //методы скрытия и раскрытия элементов
        public void DeMethod1()
        {
            if (des_first.IsChecked == true)
            {
                des_text_l.IsVisible = true;
                des_text.IsVisible = true;
                des_key_l.IsVisible = true;
                des_key.IsVisible = true;
               
            }
            else
            {
                des_text_l.IsVisible = false;
                des_text.IsVisible = false;
                des_key_l.IsVisible = false;
                des_key.IsVisible = false;

            }
        }
        public void DeMethod2()
        {
            if (des_second.IsChecked == true)
            {
                des_text_l.IsVisible = true;
                des_text.IsVisible = true;
                des_key.IsVisible = true;
                des_key_l.IsVisible = true;
            }
            else
            {
                des_text_l.IsVisible = false;
                des_text.IsVisible = false;
                des_key.IsVisible = false;
                des_key_l.IsVisible = false;
            }
        }
        public void DeMethod3()
        {
            if (des_thi.IsChecked == true)
            {
                des_text_l.IsVisible = true;
                des_text.IsVisible = true;
                des_key.IsVisible = true;
                des_key2.IsVisible = true;
                des_key_l.IsVisible = true;
                des_D.IsVisible = true;
                des_N.IsVisible = true;
            }
            else
            {
                des_text_l.IsVisible = false;
                des_text.IsVisible = false;
                des_key.IsVisible = false;
                des_key2.IsVisible = false;
                des_key_l.IsVisible = false;
                des_D.IsVisible = false;
                des_N.IsVisible = false;
            }
        }
        public bool has2;
        //События изменения состояния checkbox
        private async void des_first_CheckChanged(object sender, EventArgs e)
        {
            Ochistka_dannix_des();
            if (des_second.IsChecked == true || des_thi.IsChecked == true)
            {
                has2 = false;
            }
            else
            {
                has2 = true;
            }

            if (has2 == true)
            {
                
                DeMethod1();
            }
            else
            {
                des_first.IsChecked = false;
                await DisplayAlert("Исключение", "У вас выбран метод", "OK");
            }
        }

        private async void des_second_CheckChanged(object sender, EventArgs e)
        {
            Ochistka_dannix_des();
            if (des_first.IsChecked == true || des_thi.IsChecked == true)
            {
                has2 = false;
            }
            else
            {
                has2 = true;
            }

            if (has2 == true)
            {
                
                DeMethod2();
            }
            else
            {
                des_second.IsChecked = false;
                await DisplayAlert("Исключение", "У вас выбран метод", "OK");
            }
        }

        private async void des_thi_CheckChanged(object sender, EventArgs e)
        {
            Ochistka_dannix_des();
            if (des_second.IsChecked == true || des_first.IsChecked == true)
            {
                has2 = false;
            }
            else
            {
                has2 = true;
            }

            if (has2 == true)
            {
                
                DeMethod3();
            }
            else
            {
                des_thi.IsChecked = false;
                await DisplayAlert("Исключение", "У вас выбран метод", "OK");
            }
        }

        //метод рашифровки решелье
        private void DEReshilie()
        {
            Reshil reshil = new Reshil();
            Kript.Text = reshil.DeShifiring(des_text.Text, des_key.Text);

        }
        
        private void DeVizener()
        {
            Visener vizener = new Visener();
            if (des_text.Text == "")
            {
                Oshibka();
            }
            else
            {
                string dekript = vizener.DeShifr(des_text.Text.ToUpper(), des_key.Text.ToUpper());
                Kript.Text = dekript.ToLower();
            }

        }
        public string alp = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ";
        //метод рашифровки RSA
        public void DeRSA()
        {
            RSA RASA = new RSA();
            string text1 = des_text.Text;
            string[] word = text1.Split(new char[] { ' ' });
            List<BigInteger> arrayList = new List<BigInteger>();

            for (int i = 0; i < word.Length; i++)
            {
                arrayList.Add((BigInteger)Convert.ToInt32(word[i]));
            }
            int a = Convert.ToInt32(des_key.Text);
            int b = Convert.ToInt32(des_key2.Text);
            Kript.Text = RASA.Text(arrayList, a, b);
           
           


        }
        public void Ochistka_dannix_shifiring()
        {
            shifiring_key.Text = "";
            shifiring_keys.Text = "";
            shifiring_kript.Text = "";
            shifiring_text.Text = "";
            
        }
        public void Ochistka_dannix_des()
        {
            des_key.Text = "";
            des_key2.Text = "";
            Kript.Text = "";
            des_text.Text = "";
            
        }
        private void des_but_Clicked(object sender, EventArgs e)
        {
            if (des_first.IsChecked == true)
            {
                DEReshilie();
            }
            else if (des_second.IsChecked == true)
            {
                DeVizener();
            }
            else if (des_thi.IsChecked == true)
            {
                DeRSA();
            }
        }
    }
}
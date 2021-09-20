using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OIP
{
    public partial class MainPage : ContentPage
    {
        public bool Proc;
        public MainPage(bool process)
        {
            Color ob;
            Color tes;
            Proc = process;
            if (process == true)
            {
                tes = Color.Pink;
                ob = Color.DarkRed;

            }
            else
            {
                ob = Color.SkyBlue;
                tes = Color.DarkRed;

            }
            InitializeComponent();
            Check_text();
           Nachalo(ob,tes);
        }
        public void Nachalo(Color a, Color b)
        {
            first.BackgroundColor = b;
            first.BorderColor = b;
            Main.BackgroundColor = a;

        }

        Color a = Color.DarkRed;
        public void Check_text()
        {
            if (Proc==true)
            {
                name1.TextColor = Color.Pink;
                text.TextColor = Color.Pink;
            }
            else
            {
                text.TextColor = Color.DarkRed;
                name1.TextColor = Color.DarkRed;
            }
            if (Znach_1 == 1)
            {
                name1.Text = "Дешифрование";
                text.Text = "ДЕШИФРОВАНИЕ — (дешифровка) — процесс перевода текста или изображения, принятого в виде последовательности сигналов, из зашифрованной формы в незашифрованную с помощью дешифратора";
                text.FontSize = 20;
            }
            else if (Znach_1 == 2)
            {
                name1.Text = "Пользование-Шифратором";
                name1.FontSize = 26;
                name1.HorizontalOptions = LayoutOptions.Center;
            }
            else if (Znach_1 == 3)
            {
                name1.Text = "Пользование-Дешифратором";
                name1.FontSize = 26;
                name1.HorizontalOptions = LayoutOptions.Center;
            }
            else if (Znach_1 == 0)
            {
                name1.Text = "Шифрование";
                text.Text = "Шифрова́ние — преобразование информации в целях сокрытия от неавторизованных лиц, с предоставлением, в это же время, авторизованным пользователям доступа к ней. Главным образом, шифрование служит задаче соблюдения конфиденциальности передаваемой информации. Важной особенностью любого алгоритма шифрования является использование ключа, который утверждает выбор конкретного преобразования из совокупности возможных для данного алгоритма.";
                text.FontSize = 20;
            }
        }
        public int Znach_1 = 0;
        public void Next2()
        {
            TXT();
            if (Znach_1 == 3)
            {
                thi.BackgroundColor = Color.Black;
                thi.BorderColor = Color.Black;
                if (Proc== true)
                {
                    four.BackgroundColor = Color.Pink;
                    four.BorderColor = Color.Pink;

                }
                else
                {
                    four.BackgroundColor = Color.DarkRed;
                    four.BorderColor = Color.DarkRed;
                }

                second.BackgroundColor = Color.Black;
                second.BorderColor = Color.Black;
                first.BackgroundColor = Color.Black;
                first.BorderColor = Color.Black;

                Check_text();
            }
            else if (Znach_1 == 2)
            {
                if (Proc== true)
                {
                    thi.BackgroundColor = Color.Pink;
                    thi.BorderColor = Color.Pink;

                }
                else
                {
                    thi.BorderColor = Color.DarkRed;
                    thi.BackgroundColor = Color.DarkRed;
                }
                four.BackgroundColor = Color.Black;
                four.BorderColor = Color.Black;
                first.BackgroundColor = Color.Black;
                first.BorderColor = Color.Black;
                
                second.BackgroundColor = Color.Black;
                second.BorderColor = Color.Black;
                Check_text();
            }
            else if (Znach_1 == 1)
            {
                if (Proc== true)
                {
                    second.BackgroundColor = Color.Pink;
                    second.BorderColor = Color.Pink;

                }
                else
                {
                    second.BackgroundColor = Color.DarkRed;
                    second.BorderColor = Color.DarkRed;
                }
                first.BackgroundColor = Color.Black;
                first.BorderColor = Color.Black;
                thi.BackgroundColor = Color.Black;
                thi.BorderColor = Color.Black;
                four.BackgroundColor = Color.Black;
                four.BorderColor = Color.Black;

                Check_text();
            }
            else if (Znach_1==0)
            {
                second.BackgroundColor = Color.Black;
                second.BorderColor = Color.Black;
                if (Proc== true)
                {
                    first.BackgroundColor = Color.Pink;
                    first.BorderColor = Color.Pink;

                }
                else
                {
                    first.BorderColor = Color.DarkRed;
                    first.BackgroundColor = Color.DarkRed;
                }
                thi.BackgroundColor = Color.Black;
                thi.BorderColor = Color.Black;
                four.BackgroundColor = Color.Black;
                four.BorderColor = Color.Black;
                Check_text();
            }
        }
        public void Next()
        {
            TXT();
            if (Znach_1 == 3)
            {
                four.BackgroundColor = Color.Black;
                four.BorderColor = Color.Black;
                Znach_1 = Znach_1 - 1;
                if (Proc== true)
                {
                    thi.BackgroundColor = Color.Pink;

                    thi.BorderColor = Color.Pink;

                }
                else
                {
                    thi.BorderColor = Color.DarkRed;
                    thi.BackgroundColor = Color.DarkRed;
                }
                Check_text();
            }
            else if (Znach_1 == 2)
            {
                thi.BackgroundColor = Color.Black;
                thi.BorderColor = Color.Black;
                Znach_1 = Znach_1 - 1;
                if (Proc == true)
                {
                    second.BackgroundColor = Color.Pink;
                    second.BorderColor = Color.Pink;

                }
                else
                {
                    second.BorderColor = Color.DarkRed;
                    second.BackgroundColor = Color.DarkRed;
                }

                Check_text();
            }
            else if (Znach_1 == 1)
            {
                second.BackgroundColor = Color.Black;
                second.BorderColor = Color.Black;
                Znach_1 = Znach_1 - 1;
                if (Proc== true)
                {
                    first.BackgroundColor = Color.Pink;
                    first.BorderColor = Color.Pink;

                }
                else
                {
                    first.BorderColor = Color.DarkRed;
                    first.BackgroundColor = Color.DarkRed;
                }
                Check_text();
            }
        }
        
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Next();
            TXT();
        }
        public async void Old()
        {
            TXT();
            if (Znach_1 == 0)
            {
                if (Proc == true)
                {
                    second.BackgroundColor = Color.Pink;
                    second.BorderColor = Color.Pink;

                }
                else
                {
                    second.BackgroundColor = Color.DarkRed;
                    second.BorderColor = Color.DarkRed;
                }
                Znach_1 = Znach_1 + 1;
                first.BackgroundColor = Color.Black;
                first.BorderColor = Color.Black;
                Check_text();
            }
            else if (Znach_1 == 1)
            {
                if (Proc==true)
                {
                    thi.BackgroundColor = Color.Pink;
                    thi.BackgroundColor = Color.Pink;

                }
                else
                {
                    thi.BorderColor = Color.DarkRed;
                    thi.BackgroundColor = Color.DarkRed;
                }
                Znach_1 = Znach_1 + 1;
                second.BackgroundColor = Color. Black;
                second.BorderColor = Color.Black;
                Check_text();

            }
            else if (Znach_1 == 2)
            {
                if (Proc== true)
                {
                    four.BackgroundColor = Color.Pink;
                    four.BorderColor = Color.Pink;

                }
                else
                {
                    four.BorderColor = Color.DarkRed;
                    four.BackgroundColor = Color.DarkRed;
                }
                Znach_1 = Znach_1 + 1;
                thi.BackgroundColor = Color.Black;
                thi.BorderColor = Color.Black;
                Check_text();

            }
            else if (Znach_1 == 3)
            {
               
                await Navigation.PushModalAsync(new OIP.First(Proc));

            }
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {

            Old();
            TXT();
        }
        
        private void first_Clicked(object sender, EventArgs e)
        {
            Znach_1 =0;
            Next2();
            TXT();

            
        }

        private void second_Clicked(object sender, EventArgs e)
        {
            Znach_1 = 1;
            TXT();
            Next2();
        }

        private void thi_Clicked(object sender, EventArgs e)
        {
            TXT();
            Znach_1 = 2;
            Next2();
        }

        private void four_Clicked(object sender, EventArgs e)
        {
            TXT();
            Znach_1 = 3;
            Next2();
        }
       
	     public void TXT()
        {
            if (Znach_1==3)
            {
                op.Text = "Выйти";
            }
            else
            {
                op.Text = "Вперед";
            }
        }
    }
}

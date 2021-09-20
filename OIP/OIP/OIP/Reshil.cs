using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace OIP
{
    class Reshil
    {
        ArrayList revers = new ArrayList();
        ArrayList razner = new ArrayList();
        ArrayList text12 = new ArrayList();


        ArrayList oldtext = new ArrayList();
        public void Shifrovka(string text)
        {


            Random random = new Random();
            oldtext.Add(text);
            string[] array_text = text.Split(' ');
            char[] answer;
            string Key = "";

            for (int i = 0; i < array_text.Length; i++)
            {
                int[] array1 = new int[array_text[i].Length];

                for (int ik = 0; ik < array1.Length; ik++)
                {
                    array1[ik] = ik;
                    razner.Add(ik);
                }

                int[] array2 = new int[array1.Length];



                for (int j1 = 0; j1 < array2.Length; j1++)
                {
                    array2[j1] = array1[random.Next(array1.Length)];
                    array1 = array1.Where(x => x != array2[j1]).ToArray();

                }


                answer = array_text[i].ToCharArray();
                revers.Add(answer);


                for (int j = 0; j < array_text[i].Length; j++)
                {
                    answer[array2[j]] = array_text[i][j];
                    Key += array2[j];
                    Key += " ";


                }



                Key += " ";
                Console.Write(" ");



                Console.WriteLine();

            }
            text12.Add(Key);




        }
        public ArrayList Show_kt()
        {

            return revers;

        }
        public ArrayList Show()
        {
            return text12;
        }
        public string DeShifiring(string Keykrip, string key)
        {
            string old = "";
            //Console.Write("Ввести криптограмму: ");

            //string Keykrip = Console.ReadLine();
            //ArrayList Kriop = new ArrayList();
            // string key = Console.ReadLine();
            char[] charp = key.ToCharArray();
            //  Kriop.AddRange(charp);

            string[] arrayKrip = Keykrip.Split(' ');
            string[] y = new string[charp.Length];

            string NewStroka = "";
            for (int i = 0; i < arrayKrip.Length; i++)
            {

                int[] massiv = new int[arrayKrip[i].Length];

                //Console.WriteLine("Ключ для слова: " + arrayKrip[i]);

                for (int j = 0; j < arrayKrip[i].Length; j++)
                {
                    int a;
                    //  int a = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine(Convert.ToString(charp[i])); //1 2 3...
                    y[j] = Convert.ToString(charp[j]);
                    a = Convert.ToInt32(y[j]);
                    //Console.WriteLine(Convert.ToString(a));
                    //int a = Convert.ToInt32(item);
                    old += arrayKrip[i][a];


                }
                NewStroka += " " + old;
            }
            return NewStroka;

        }
    }
}

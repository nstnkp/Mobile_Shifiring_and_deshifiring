using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Numerics;

namespace OIP
{
    class RSA
    {
        Random rand = new Random();
        ArrayList list1 = new ArrayList();
        List<BigInteger> list_index = new List<BigInteger>();
        public string alp = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ";
        public double p, q, Fn;
        public int d, N, e;
        public double[] Prostie_chisla = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        public List<BigInteger> Shifr(string slovo)
        {
          
            p = Prostie_chisla[rand.Next(0, Prostie_chisla.Length)];
            q = Prostie_chisla[rand.Next(0, Prostie_chisla.Length)];
            N = Convert.ToInt32(q * p);
            Fn = (p - 1) * (q - 1);
          
            for (int i = 1; i < Prostie_chisla.Length; i++)
            {
                if (Prostie_chisla[i] % N != 0 && Prostie_chisla[i] < Fn)
                {
                    list1.Add(Prostie_chisla[i]);
                }
            }
            e = Convert.ToInt32(list1[rand.Next(list1.Count)]);
            
            char[] mass = slovo.ToCharArray();
            for (int i = 0; i < mass.Length; i++)
            {
                BigInteger big = (BigInteger.Pow(alp.IndexOf(mass[i]), e) % N);
                list_index.Add(big);
            }
            
            d = 0;
            while ((d * e) % Fn != 1)
            {
                d++;
            };
            
            return list_index;
            
        }
        public int Return_D()
        {
            return d;
        }
        public int Return_N()
        {
            return N;
        }
        public string Text(List<BigInteger> For_rash, int D, int n)
        {
            string slovozak = "";
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < For_rash.Count; i++)
            {
                BigInteger lol = (BigInteger.Pow(For_rash[i], D) % n);
                arrayList.Add(lol);
            }
            foreach (BigInteger big in arrayList)
            {
               // Console.Write(big + " ");
                slovozak += alp[(int)big];
            }
            return slovozak;
        }
    
}
}

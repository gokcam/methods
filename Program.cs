using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a =3;
            int b=4;
            Console.WriteLine("Hello World!");
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc) );

            int sonuc2=ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));

            ornek.EkranaYazdir(Convert.ToString(a+b) );



        }



        static int Topla(int a, int b)
        {
            return a+b;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;

        }
    }
}
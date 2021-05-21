using System;

namespace metotlar3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for(int i =1; i < 5; i++)
            result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            string ifade = "Haluk Keskin";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc)
            Console.WriteLine(ifade.RemovethWhitSpaces());

            Console.WriteLine(ifade.MakerUpper());
            Console.WriteLine(ifade.MakerLower());

            int[] dizi = {9,6,4,7,1,2,5};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEventNumber());
            
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler {

        public int Expo(int sayi, int üs)
        {
            if(üs < 2)
            return sayi;
            return Expo(sayi, üs-1) * sayi;
        }
    }

    public static class Extension{
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemovethWhitSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static string MakerUpper (this string param)
        {
            return param.ToUpper();
        }
        public static string MakerLower (this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach(int item in param)
            Console.WriteLine(item);
        }
        public static bool IsEventNumber(this int param)
        {
            return param%2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}

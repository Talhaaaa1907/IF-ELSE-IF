using System;

namespace IF_ELSE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<=12)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time<18 && time>12)
            {
                System.Console.WriteLine("İyi Günler");
            }
            else if (time>=18)
            {
                System.Console.WriteLine("İyi Akşamlar!");
            }
            
            string sonuc = time>=6 && time<12 ? "Günaydın" : time>12 && time<18 ? "İyi Günler" : "İyi Akşamlar";
            System.Console.WriteLine(sonuc);

            Console.ReadLine();

        }
    }
}

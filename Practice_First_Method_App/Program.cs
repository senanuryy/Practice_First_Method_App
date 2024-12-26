using System;

namespace FirstMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Lyrics()
            {
                Console.WriteLine("Dein hirn ein schlachtfeld tag und nacht");
            }

            Lyrics();

            Console.WriteLine("--------------------------------------------------------------------------------");

            int GetRemainderOfTwo()
            {
                Random rnd = new Random();

                int rndNum = rnd.Next(1, 5942);
                
                return rndNum % 2;                                
            }

            Console.WriteLine("Random sayının 2'ye bölümünden kalan = " + GetRemainderOfTwo());

            Console.WriteLine("--------------------------------------------------------------------------------");

            int Multiply (int num1, int num2)
            {                
                return num1 * num2;
            }

            Console.Write("İlk sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = Multiply(x, y);
            Console.WriteLine(x + " * " + y + " = " + result);

            Console.WriteLine("--------------------------------------------------------------------------------");

            void Welcome(string name, string surname)
            {
                Console.WriteLine($"Hoş Geldiniz {name} {surname}");                
            }

            Console.Write("Adınız: ");
            string name = Console.ReadLine();

            Console.Write("Soyadınız: ");
            string surname = Console.ReadLine();

            Welcome(name, surname);                     

        }
    }
}

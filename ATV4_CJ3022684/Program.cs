// ATV.CAUCULADORA
using System.Data;

namespace ATV4_CJ3022684
{
    internal class program
    {
       static void Main(string[] args) 
       {
            float op, n1, n2;
            Console.WriteLine("digite o numero de n1;");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero de n2;");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("1- multiplicação, 2- divisão, 3-adição, 4- subtração");
            op = float.Parse(Console.ReadLine());

            switch (op)



            {
                case 1:

                    Console.WriteLine(n1 * n2);
                    Console.WriteLine("multiplicação");
                    break;

                case 2:

                    Console.WriteLine(n1 / n2);
                    Console.WriteLine("divisão");
                    break;

                case 3:

                    Console.WriteLine(n1 + n2);
                    Console.WriteLine("adição");
                    break;

                case 4:

                    Console.WriteLine(n1 - n2);
                    Console.WriteLine("subtração");
                    break;
            }
      
        } 
    }
}
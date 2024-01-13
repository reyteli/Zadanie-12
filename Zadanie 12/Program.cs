using System;


namespace Zadanie_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите r");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            double square = Cycle.GetSquare(r);
            double dlina = Cycle.GetDlina(r);
            double proverka = Cycle.GetProverka(r,x,y);
            if (proverka <= r)
                Console.WriteLine("Точка М лежит в круге.");
            else
                Console.WriteLine("Точка М лежит вне круга.");
            Console.WriteLine($"{square} \n{dlina}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Diagnostics.Eventing.Reader;

namespace Math_Line_Graph
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var app = new IFMGraph();
            while (true)
            {

                app.Run();
                Console.WriteLine("chcete porkačovat? Ano/Ne/Clear");
                string a = Console.ReadLine();
                if (a == "Ano")
                {
                    continue;
                }
                else if (a == "Clear")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
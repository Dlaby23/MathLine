using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

namespace Math_Line_Graph
{
    public class IFMGraph
    {
        public const int Width = 221;
        public const int Height = 84;
        public string[,] _soustava = new string[Height, Width];
        public void Run()
        {            
            VytvářeníGraph();
            Console.Write("pro k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("pro q: ");
            double q = Convert.ToDouble(Console.ReadLine());
            PočítáníRovnice(-k, -q);
            KresleníGraph();     

        }
        public void VytvářeníGraph()
        {
            
            for (var i = 0; i < Height; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    if (j == (Width / 2))
                    {
                        _soustava[i, j] = "|";
                    }
                    else if (i == (Height / 2))
                    {
                        _soustava[i, j] = "-";
                    }
                    else
                    {
                        _soustava[i, j] = " ";
                    }
                }
            }
        }

        public void KresleníGraph()
        {
            for (var i = 0; i < Height; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    Console.Write(_soustava[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void ZapsáníGraphu(double x, double y)
        {
            try
            {
                //Pragram na každou sořadnici x a y zapíše "*"
                _soustava[(int)y, (int)x] = "*";
            }
            catch
            {
                //program nic neudělá nic a běží dál
            }

        }

        public void PočítáníRovnice(double k, double q)
        {
            //upravuje délku přímky
            for (double x = -100.0; x < 100.0; x++)
            {
                double y = k * x + q;
                ZapsáníGraphu(x + (Width / 2.0), y + (Height / 2.0));

            }            
        }        
    }
}
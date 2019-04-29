using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsciiArts
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                QuadradoPreenchido();
                
                Thread.Sleep(5000);
                Console.Clear();
                
                Escada();
                
                Thread.Sleep(5000);
                Console.Clear();
                
                X();
                
                Thread.Sleep(5000);
                Console.Clear();
                
                TrianguloPreenchido();
                
                Thread.Sleep(5000);
                Console.Clear();
                
                LosangoPreenchido();

                Thread.Sleep(5000);
                Console.Clear();

                Circulo();

                Thread.Sleep(5000);
                Console.Clear();
            }
        }

        static void X()
        {
            int largura = 21;

            int a = 1;
            int b = largura - 1;

            Console.WriteLine();

            while (a < largura)
            {
                for (int c = 0; c < largura; c++)
                {
                    if (a == c || b == c)
                    {
                        Console.Write("#");
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                a++;
                b--;

                Console.WriteLine();
            }
        }

        static void Escada()
        {
            int larguraDegrau = 3;
            int qtdDegraus = 20;

            int larguraTotal = qtdDegraus * larguraDegrau;

            int numDegrau = 0;

            while (numDegrau < qtdDegraus)
            {
                for (int c = 0; c < larguraTotal; c++)
                {
                    if (c == numDegrau * larguraDegrau)
                    {
                        for (int ld = 0; ld < larguraDegrau; ld++)
                        {
                            Console.Write("#");
                            Thread.Sleep(300);
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                numDegrau++;
            }
        }

        static void LosangoPreenchido()
        {
            int margem = 5;
            int largura = 25;
            int centro = largura / 2;
            int area = 0;

            Console.WriteLine();
            for (int m = 0; m < margem; m++) Console.Write(" ");

            while (area < largura / 2)
            {
                for (int c = 0; c < largura; c++)
                {
                    if (c >= centro - area && c <= centro + area)
                    {
                        Console.Write("#");
                        Thread.Sleep(50);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                area++;
                Console.WriteLine();
                for (int m = 0; m < margem; m++) Console.Write(" ");
            }

            while (area >= 0)
            {
                for (int c = 0; c < largura; c++)
                {
                    if (c >= centro - area && c <= centro + area)
                    {
                        Console.Write("#");
                        Thread.Sleep(50);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                area--;
                Console.WriteLine();
                for (int m = 0; m < margem; m++) Console.Write(" ");
            }
        }

        static void TrianguloPreenchido()
        {
            Console.WriteLine();

            int largura = 31;
            int centro = largura / 2;
            int area = 0;

            while (area < largura / 2)
            {
                for (int c = 0; c < largura; c++)
                {
                    if (c >= centro - area && c <= centro + area)
                    {
                        Console.Write("#");
                        Thread.Sleep(50);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                area++;
                Console.WriteLine();
            }
        }

        static void QuadradoPreenchido()
        {
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine();

                for (int c = 0; c < 10; c++)
                {
                    Console.Write("#");
                    Thread.Sleep(200);
                }
            }
        }

        static void Circulo()
        {
            Console.WriteLine();

            int margem = 5;
            int diametro = 50;
            int raio = diametro / 2;

            for (int v = 0; v <= diametro; v++)
            {
                for (int m = 0; m < margem; m++)
                    Console.Write(" ");

                double x1 = raio - Math.Sqrt(
                    Math.Pow(raio, 2) - Math.Pow((raio - v), 2)
                    );

                double x2 = raio + Math.Sqrt(
                    Math.Pow(raio, 2) - Math.Pow((raio - v), 2)
                    );

                for (int h = 0; h < diametro; h++)
                {
                    if (h >= (int)x1 && h <= x2)
                    {
                        Console.Write("**");
                        Thread.Sleep(25);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
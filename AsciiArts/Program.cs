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
                Retangulo();
                Sleep();
                Console.Clear();

                Escada();
                Sleep();
                Console.Clear();

                TrianguloReto();
                Sleep();
                Console.Clear();

                TrianguloEquilatero();
                Sleep();
                Console.Clear();

                Losango();
                Sleep();
                Console.Clear();

                X();
                Sleep();
                Console.Clear();

                Trapezio();
                Sleep();
                Console.Clear();

                Circulo();
                Sleep();
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
                        Thread.Sleep(100);
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

        static void Trapezio()
        {
            Console.WriteLine();

            int baseMaior = 22;
            int baseMenor = 11;
            int margem = (baseMaior - baseMenor) / 2;
            int aux = 0;

            while (aux <= margem)
            {
                for (int h = 0; h <= baseMaior; h++)
                {
                    if (h >= margem - aux && h <= margem + baseMenor + aux)
                    {
                        Console.Write("**");
                        Thread.Sleep(50);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
                aux++;
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
                            Thread.Sleep(100);
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

        static void Losango()
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
                        Thread.Sleep(25);
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

        static void TrianguloEquilatero()
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
                        Thread.Sleep(25);
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

        static void TrianguloReto()
        {
            Console.WriteLine();

            int altura = 10;

            for (int y = 0; y < altura; y++)
            {
                for (int aux = 0; aux <= y; aux++)
                {
                    Console.Write("#");
                    Thread.Sleep(25);
                }

                Console.WriteLine();
            }
        }

        static void Retangulo()
        {
            for (int l = 0; l < 15; l++)
            {
                Console.WriteLine();

                for (int c = 0; c < 10; c++)
                {
                    Console.Write("#");
                    Thread.Sleep(30);
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
                        Thread.Sleep(5);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Sleep()
        {
            Thread.Sleep(3000);
        }
    }
}
using System;

namespace kalkulator_terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź cyfrę odpowiadający działaniu:");
            Console.WriteLine("1 = Dodawanie\n2 = Odejmowanie\n3 = Mnożenie\n4 = Dzielenie\n5 = Potęgowanie\n6 = Pierwiastkowanie");
            //int dzialanie = int.Parse(Console.ReadLine());
            double a, b, wynik;

            if (double.TryParse(Console.ReadLine(), out double dzialanie))
            {
                switch (dzialanie)
                {
                    case 1:
                        {
                            Console.WriteLine("Wprowadź pierwszą liczbę:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Wprowadź drugą liczbę:");
                            b = double.Parse(Console.ReadLine());

                            wynik = a + b;

                            Console.WriteLine("Wynik dodawania wynosi: {0}.", wynik);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Wprowadź pierwszą liczbę:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Wprowadź drugą liczbę:");
                            b = double.Parse(Console.ReadLine());

                            wynik = a - b;

                            Console.WriteLine("Wynik odejmowania wynosi: {0}.", wynik);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Wprowadź pierwszą liczbę:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Wprowadź drugą liczbę:");
                            b = double.Parse(Console.ReadLine());

                            wynik = a * b;

                            Console.WriteLine("Wynik mnożenia wynosi: {0}.", wynik);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Wprowadź dzielną:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Wprowadź dzielnik:");
                            b = double.Parse(Console.ReadLine());

                            wynik = a / b;

                            Console.WriteLine("Wynik dzielenia wynosi: {0}.", wynik);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Wprowadź podstawę potęgi:");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Wprowadź wykładnik potęgi:");
                            b = double.Parse(Console.ReadLine());

                            wynik = Math.Pow(a, b);

                            Console.WriteLine("Wynik potęgowania wynosi: {0}.", wynik);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Wprowadź liczbę pierwiastkowaną:");
                            a = double.Parse(Console.ReadLine());

                            wynik = Math.Sqrt(a);

                            Console.WriteLine("Wynik pierwiastkowania wynosi: {0}.", wynik);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Brak działania przypisanego do wprowadzonej cyfry.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Zły klawisz!");
            }
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonGB3
{

    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1");
            Console.WriteLine("");
            Ex1Complex();
            Console.WriteLine("");
            Console.WriteLine("Задание 2");
            Console.WriteLine("");

            Exer2();



            Console.ReadLine();
        }
        static void Ex1Complex()
        {
            Complex z1 = new Complex();
            z1.A = 2;
            z1.B = 3;
            Console.WriteLine(z1);


            Complex z2 = new Complex(Re: 0, Im: -20);
            z2.A = 2;
            z2.B = 1;

            Console.WriteLine(z2);

            Complex z3 = Complex.Sum(z1, z2);
            Console.WriteLine(z3);
            Complex z4 = Complex.Dif(z1, z2);
            Console.WriteLine(z4);
            Complex z5 = Complex.Mult(z1, z2);
            Console.WriteLine(z5);

        
        }
        static void Exer2()
        {

            int sum = 0;
            string z = "";
            int AmountOfOddNumbers = 0;
            Ex2();

             void Ex2() {
                
                Console.WriteLine("Введите число от 1 до 9");
                string s = Console.ReadLine();
                int n;
                if (!int.TryParse(s, out n))
                {
                    Console.WriteLine("Ошибка! Вы должны ввести число!");
                }


                else if (n % 2 != 0 && AmountOfOddNumbers == 0)
                {
                    
                    sum += n;
                    z += $"{n}";
                    AmountOfOddNumbers++;
                }
                else if (n % 2 != 0 && AmountOfOddNumbers > 0)
                {

                    sum += n;
                    z += $"+{n}";
                    AmountOfOddNumbers++;
                }


                else if (n == 0)
                {
                    z += $"={sum}";
                    Console.WriteLine(z);
                    Console.WriteLine("Сумма нечетных чисел = " + sum);

                    sum = 0;
                    z = "";
                    AmountOfOddNumbers = 0;

                }
                Ex2();

            }

            }
        }

    }


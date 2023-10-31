using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

                Console.WriteLine("октавы на ф5 и ф6");
                Console.WriteLine("кнопукуки вроде на qwertyu 13457");
                ConsoleKeyInfo key = Console.ReadKey();
                Sound(Octava(key));
            }


            static int[] Octava(ConsoleKeyInfo key)
            {

                int[] unknown = new int[0];

                if (key.Key == ConsoleKey.F5)
                {
                    int[] FO = new int[] { 523, 554, 587, 622, 659, 740, 698, 830, 784, 880, 932, 987 };
                    int[] Oct = FO.Where(item => item != 1).ToArray();
                    return Oct;
                }
                if (key.Key == ConsoleKey.F6)
                {
                    int[] SO = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    int[] Oct = SO.Where(item => item != 1).ToArray();
                    return Oct;
                }
                return unknown;
            }


            static void Sound(int[] Oct)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                while (true)
                {
                    Console.Clear();
                    if (key.Key == ConsoleKey.Q) // C
                    {
                        Console.Beep(Oct[0], 300);
                    }

                    if (key.Key == ConsoleKey.D1) //C#
                    {
                        Console.Beep(Oct[1], 300);
                    }

                    if (key.Key == ConsoleKey.W) // D
                    {
                        Console.Beep(Oct[2], 300);
                    }

                    if (key.Key == ConsoleKey.D3) // Eb
                    {
                        Console.Beep(Oct[3], 300);
                    }

                    if (key.Key == ConsoleKey.E) // E
                    {
                        Console.Beep(Oct[4], 300);
                    }

                    if (key.Key == ConsoleKey.D4) // F#
                    {
                        Console.Beep(Oct[5], 300);
                    }

                    if (key.Key == ConsoleKey.R) // F
                    {
                        Console.Beep(Oct[6], 300);
                    }

                    if (key.Key == ConsoleKey.D5) // G#
                    {
                        Console.Beep(Oct[7], 300);
                    }

                    if (key.Key == ConsoleKey.T) // G
                    {

                        Console.Beep(Oct[8], 300);
                    }

                    if (key.Key == ConsoleKey.Y) // A
                    {
                        Console.Beep(Oct[9], 300);
                    }

                    if (key.Key == ConsoleKey.D7) // A#
                    {
                        Console.Beep(Oct[10], 300);
                    }

                    if (key.Key == ConsoleKey.U) // B
                    {
                        Console.Beep(Oct[11], 300);
                    }
                    key = Console.ReadKey();
                }

            }
        }
    }


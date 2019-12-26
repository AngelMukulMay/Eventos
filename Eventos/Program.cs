using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program that calculates time between two dates");

            //Initialize Variable
            string[] text = new string[99];

            try
            {
                // Read the file as one string.
                text = File.ReadAllLines(@"C:\Users\angel.mukul\source\repos\Eventos\TextFile.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("An unknown error happened");
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error happened");
            }

            DateTime DateFromExecution = DateTime.Now;

            string onlyDate = string.Empty;
            TimeSpan newDate = new TimeSpan();

            foreach (string line in text)
            {
                onlyDate = Regex.Replace(line, @"[a-zA-Z:]", string.Empty);
                if (Convert.ToDateTime(onlyDate) > DateFromExecution)
                {
                    newDate = Convert.ToDateTime(onlyDate).Subtract(DateFromExecution);
                    Console.WriteLine("Faltan: " + newDate.Days + "Días");
                }
                else
                {
                    newDate = DateFromExecution.Subtract(Convert.ToDateTime(onlyDate));
                    Console.WriteLine("Fue hace: " + newDate.Days + "Días");
                }
                      
            }

            Console.ReadKey();
        }
    }
}

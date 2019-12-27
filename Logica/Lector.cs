using Interfaces;
using System;
using System.IO;

namespace Logica
{
    public class Lector : ILector
    {
        public string[] GetTextFromFile(string cRuta)
        {
            string[] text = new string[] { };

            try
            {
                text = File.ReadAllLines(cRuta);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error happened");
            }

            return text;
        }
    }
}

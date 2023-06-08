using System.Text.RegularExpressions;

namespace Test


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name= Console.ReadLine();
            Console.WriteLine(name);
            //string namepattern = "^[A-Z]{1}[a-z]{2,}$";
           //string namepattern = "^[A-Z]{1}[a-z]{2,}$";
            //string namepattern = "^[w]{3}[.][a-z]{5,}[.][a-z]{2,}$";
            //string namepattern = "^[0-9a-zA-Z]+[.-_]{0,2}[0-9a-zA_z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            //string namepattern = "^[0-9]{2}[ ][0-9]{10}$";
            //string namepattern = "^[0-9a-zA-z]{8,}$";
           //string namepattern = "^[A-Z]{1}[0-9a-z]{7,}$";
            string namepattern = "^[A-Z]{1,}[A-Za-z0-9]{6,}[0-9]{1,}$";
            //string namepattern = "^[0-9]{1,}[@-_#]{1,}[A-Za-z0-9]{6,}$";
            //string namepattern = "^[A-Z]{1,}[A-Za-z0-9]{5,}[@!$^*#]{1}[0-9]{1,}$";
            Regex regex = new Regex(namepattern); 
           

            if (regex.IsMatch(name)) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invald");
                Console.ResetColor();
            }
        }
    }
}
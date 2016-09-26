using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_26_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Varriables Here

            string answerOne = "Hello World";
            int answerTwo = 1492;
            bool dogAtHome = true;
            DateTime todayDate = DateTime.Today;
            double aPrice = 5.45;
            string aNumber = "X";

            // Code Logic here

            Console.WriteLine(answerOne);
            Console.WriteLine("Columbus Sailed the world in" + " " + answerTwo);
            Console.WriteLine("It is " + dogAtHome + " that I have a dog at home." + dogAtHome);
            Console.WriteLine(todayDate);
            Console.WriteLine("I spent " + "$" + aPrice + " on a cheeseburger");
            Console.WriteLine(aNumber + " marks the spot");


            // Favorite Movies Arrays


            string[] favoritMovies = new string[] { "Da Vinci Code", "Italian Job", "The matrix", "Wanted" };

            // Code Logic here

            Console.WriteLine(favoritMovies[0]);
            Console.WriteLine(favoritMovies[1]);
            Console.WriteLine(favoritMovies[2]);
            Console.WriteLine(favoritMovies[3]);


            // Dynamic Objects

            dynamic aArray = new[]
            {
                new {firstName = "Ike", middleName = "Frank", lastName ="cabo", birthDate = Convert.ToDateTime("09/27")},
            new { firstName = "Tim", middleName = "coby", lastName = "Jabo", birthDate = Convert.ToDateTime("08/17")}
            };

            Console.WriteLine(aArray.GetType());
            Console.WriteLine(aArray[0].firstName + "," + aArray[0].lastName + "," + aArray[0].middleName + "," + aArray[0].birthDate.ToShortDateString());

            Console.ReadLine();
        }
    }
}

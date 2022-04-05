using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IfStatement
{
    class Ifstatement
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Enter Your Score");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);
            //score = Int32.Parse(scoreAsText);

            if (score == 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Perfect score. You Win");
                Console.ResetColor();
            }
            else if(score >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You got an A");
                Console.ResetColor();
            }
            else if( score >= 70)
                //Curly braces not a must when you have a single line of code
                Console.WriteLine("You got a B");
            else if (score >= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You got an C");
                Console.ResetColor();
            }
            else if (score >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You got an D");
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You got an F");
                Console.ResetColor();
            }
        }
    }
}